using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hejduk_Zkouška
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] fileNames = new string[] { "reference.wav", "steganography-1.wav", "steganography-2.wav", "steganography-3.wav" };

            for (int fileNum = 0; fileNum < fileNames.Length; fileNum++)
            {
                string fileName = fileNames[fileNum];

                try
                {
                    BinaryReader br = new BinaryReader(File.OpenRead(fileName));

                    // počet kanálů
                    br.BaseStream.Seek(22, SeekOrigin.Begin);
                    Int16 numChannels = br.ReadInt16();
                    Console.WriteLine($"Počet kanálů: {numChannels}");

                    // SubchunkSize
                    br.BaseStream.Seek(40, SeekOrigin.Begin);
                    Int32 subchunkSize = br.ReadInt32();
                    Console.WriteLine($"Velikost Subchunk: {subchunkSize}");

                    // počet vzorků na jeden kanál
                    int numSamples = subchunkSize / numChannels;
                    Console.WriteLine($"Počet vzorků: {numSamples}");

                    // pole pro data
                    byte[,] data = new byte[numChannels, numSamples];
                    byte[] pictureData = new byte[numSamples];

                    // nastavení čtení na data
                    br.BaseStream.Seek(44, SeekOrigin.Begin);

                    // čtení dat
                    for (int sample = 0; sample < numSamples; sample++)
                    {
                        for (int channel = 0; channel < numChannels; channel++)
                        {
                            data[channel, sample] = br.ReadByte();
                        }
                    }

                    bool correct = true;
                    int blowerChannel = 0;
                    int bupperChannel = 0;
                    int checksumChannel = 0;


                    for (int i = 0; i < numChannels; i++)
                    {
                        for (int j = 0; j < numChannels; j++)
                        {
                            for (int k = 0; k < numChannels; k++)
                            {
                                for (int sample = 0; sample < numSamples; sample++)
                                {
                                    byte checksum = data[i, sample];
                                    byte blower = data[j, sample];
                                    byte bupper = data[k, sample];

                                    if (checksum != (bupper + blower) / 8 + (blower / 2))
                                    {
                                        correct = false;
                                        break;
                                    }
                                    else
                                    {
                                        checksumChannel = i;
                                        blowerChannel = j;
                                        bupperChannel = k;
                                        correct = true;
                                    }
                                }

                                if (correct) break;

                            }
                            if (correct) break;
                        }

                        if (correct) break;
                    }


                    if (!correct) continue;

                    for (int sample = 0; sample < numSamples; sample++)
                    {
                        byte blower = data[blowerChannel, sample];
                        byte bupper = data[bupperChannel, sample];
                        pictureData[sample] = (byte)((bupper << 4) | (blower));
                    }

                    BinaryWriter bw = new BinaryWriter(File.OpenWrite($"export_{fileName}.jpg"));
                    bw.Write(pictureData);
                    bw.Close();

                    br.Close();
                }
                catch (FileNotFoundException fex)
                {
                    Console.WriteLine(fex.Message);
                }


            }

            Console.ReadKey();
        }
    }
}
