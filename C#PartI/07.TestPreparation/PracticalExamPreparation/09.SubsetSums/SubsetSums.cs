using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _09.SubsetSums
{
    class SubsetSums
    {
        static void Main(string[] args)
        {
            long S = long.Parse(Console.ReadLine());
            byte N = byte.Parse(Console.ReadLine());
            long[] Number = new long[N];
            int count = new int();
            for (byte i = 0; i < N; i++)
            {
                Number[i] = long.Parse(Console.ReadLine());
            }
            for (int i = 0; i < N; i++)
            {
                if (Number[i]==S)
                {
                    count++;
                }
            }
            for (int i1 = 0; i1 < N; i1++)
            {
                for (int i2 = i1+1; i2 < N; i2++)
                {
                    if (Number[i1] + Number[i2] == S)
                    {
                        count++;
                    }
                    if (Number[i1] + Number[i2]!=S)
                    {
                        for (int i3 = i2+1; i3 < N; i3++)
                        {
                            if (Number[i1] + Number[i2] + Number[i3]== S)
                            {
                                count++;
                            }
                            if (Number[i1] + Number[i2] + Number[i3]!=S)
                            {
                                for (int i4 = i3+1; i4 < N; i4++)
                                {
                                    if (Number[i1] + Number[i2] + Number[i3] + Number[i4]== S)
                                    {
                                        count++;
                                    }
                                    if (Number[i1] + Number[i2] + Number[i3] + Number[i4] != S)
                                    {
                                        for (int i5 = i4+1; i5 < N; i5++)
                                        {
                                            if (Number[i1] + Number[i2] + Number[i3] + Number[i4] + Number[i5] == S)
                                        {
                                            count++;
                                        }
                                            if (Number[i1] + Number[i2] + Number[i3] + Number[i4] + Number[i5] != S)
                                        {
                                            for (int i6 = i5+1; i6 < N; i6++)
                                            {
                                                if (Number[i1] + Number[i2] + Number[i3] + Number[i4] + Number[i5] + Number[i6] == S)
                                                {
                                                    count++;
                                                }
                                                if (Number[i1] + Number[i2] + Number[i3] + Number[i4] + Number[i5] + Number[i6] != S)
                                                {
                                                    for (int i7 = i6+1; i7 < N; i7++)
                                                    {
                                                        if (Number[i1] + Number[i2] + Number[i3] + Number[i4] + Number[i5] + Number[i6] + Number[i7] == S)
                                                        {
                                                            count++;
                                                        }
                                                        if (Number[i1] + Number[i2] + Number[i3] + Number[i4] + Number[i5] + Number[i6] + Number[i7] != S)
                                                        {
                                                            for (int i8 = i7+1; i8 < N; i8++)
                                                            {
                                                                if (Number[i1] + Number[i2] + Number[i3] + Number[i4] + Number[i5] + Number[i6] + Number[i7] + Number[i8] == S)
                                                                {
                                                                    count++;
                                                                }
                                                                if (Number[i1] + Number[i2] + Number[i3] + Number[i4] + Number[i5] + Number[i6] + Number[i7] + Number[i8] != S)
                                                                {
                                                                    for (int i9 = i8+1; i9 < N; i9++)
                                                                    {
                                                                        if (Number[i1] + Number[i2] + Number[i3] + Number[i4] + Number[i5] + Number[i6] + Number[i7] + Number[i8] + Number[i9] == S)
                                                                        {
                                                                            count++;
                                                                        }
                                                                        if (Number[i1] + Number[i2] + Number[i3] + Number[i4] + Number[i5] + Number[i6] + Number[i7] + Number[i8] + Number[i9]!=S)
                                                                        {
                                                                            for (int i10 = i9+1; i10 < N; i10++)
                                                                            {
                                                                                if (Number[i1] + Number[i2] + Number[i3] + Number[i4] + Number[i5] + Number[i6] + Number[i7] + Number[i8] + Number[i9] + Number[i10] == S)
                                                                                {
                                                                                    count++;
                                                                                }
                                                                                if (Number[i1] + Number[i2] + Number[i3] + Number[i4] + Number[i5] + Number[i6] + Number[i7] + Number[i8] + Number[i9] + Number[i10]!=S)
                                                                                {
                                                                                    for (int i11 = i10+1; i11 < N; i11++)
                                                                                    {
                                                                                        if (Number[i1] + Number[i2] + Number[i3] + Number[i4] + Number[i5] + Number[i6] + Number[i7] + Number[i8] + Number[i9] + Number[i10] + Number[i11] == S)
                                                                                        {
                                                                                            count++;
                                                                                        }
                                                                                        if (Number[i1] + Number[i2] + Number[i3] + Number[i4] + Number[i5] + Number[i6] + Number[i7] + Number[i8] + Number[i9] + Number[i10] + Number[i11]!=S)
                                                                                        {
                                                                                            for (int i12 = i11+1; i12 < N; i12++)
                                                                                            {
                                                                                                if (Number[i1] + Number[i2] + Number[i3] + Number[i4] + Number[i5] + Number[i6] + Number[i7] + Number[i8] + Number[i9] + Number[i10] + Number[i11] + Number[i12] == S)
                                                                                                {
                                                                                                    count++;
                                                                                                }
                                                                                                if (Number[i1] + Number[i2] + Number[i3] + Number[i4] + Number[i5] + Number[i6] + Number[i7] + Number[i8] + Number[i9] + Number[i10] + Number[i11] + Number[i12]!=S)
                                                                                                {
                                                                                                    for (int i13 = i12+1; i13 < N; i13++)
                                                                                                    {
                                                                                                        if (Number[i1] + Number[i2] + Number[i3] + Number[i4] + Number[i5] + Number[i6] + Number[i7] + Number[i8] + Number[i9] + Number[i10] + Number[i11] + Number[i12]+Number[i13]==S)
                                                                                                        {
                                                                                                            count++;
                                                                                                        }
                                                                                                        if (Number[i1] + Number[i2] + Number[i3] + Number[i4] + Number[i5] + Number[i6] + Number[i7] + Number[i8] + Number[i9] + Number[i10] + Number[i11] + Number[i12]+Number[i13]!=S)
                                                                                                        {
                                                                                                            for (int i14 = i13+1; i14 < N; i14++)
                                                                                                            {
                                                                                                                if (Number[i1] + Number[i2] + Number[i3] + Number[i4] + Number[i5] + Number[i6] + Number[i7] + Number[i8] + Number[i9] + Number[i10] + Number[i11] + Number[i12] + Number[i13] + Number[i14] == S)
                                                                                                                {
                                                                                                                    count++;
                                                                                                                }
                                                                                                                if (Number[i1] + Number[i2] + Number[i3] + Number[i4] + Number[i5] + Number[i6] + Number[i7] + Number[i8] + Number[i9] + Number[i10] + Number[i11] + Number[i12] + Number[i13] + Number[i14] !=S)
                                                                                                                {
                                                                                                                    for (int i15 = i14+1; i15 < N; i15++)
                                                                                                                    {
                                                                                                                        if (Number[i1] + Number[i2] + Number[i3] + Number[i4] + Number[i5] + Number[i6] + Number[i7] + Number[i8] + Number[i9] + Number[i10] + Number[i11] + Number[i12] + Number[i13] + Number[i14] + Number[i15] == S)
                                                                                                                        {
                                                                                                                            count++;
                                                                                                                        }
                                                                                                                        if (Number[i1] + Number[i2] + Number[i3] + Number[i4] + Number[i5] + Number[i6] + Number[i7] + Number[i8] + Number[i9] + Number[i10] + Number[i11] + Number[i12] + Number[i13] + Number[i14] + Number[i15] !=S)
                                                                                                                        {
                                                                                                                            for (int i16 = i15+1; i16 < N; i16++)
                                                                                                                            {
                                                                                                                                if (Number[i1] + Number[i2] + Number[i3] + Number[i4] + Number[i5] + Number[i6] + Number[i7] + Number[i8] + Number[i9] + Number[i10] + Number[i11] + Number[i12] + Number[i13] + Number[i14] + Number[i15] + Number[i16] == S)
                                                                                                                                {
                                                                                                                                    count++;
                                                                                                                                }
                                                                                                                                if (Number[i1] + Number[i2] + Number[i3] + Number[i4] + Number[i5] + Number[i6] + Number[i7] + Number[i8] + Number[i9] + Number[i10] + Number[i11] + Number[i12] + Number[i13] + Number[i14] + Number[i15] + Number[i16]!=S)
                                                                                                                                {
                                                                                                                                    for (int i17 = i16+1; i17 < N; i17++)
                                                                                                                                    {
                                                                                                                                        if (Number[i1] + Number[i2] + Number[i3] + Number[i4] + Number[i5] + Number[i6] + Number[i7] + Number[i8] + Number[i9] + Number[i10] + Number[i11] + Number[i12] + Number[i13] + Number[i14] + Number[i15] + Number[i16] + Number[i17] == S)
                                                                                                                                        {
                                                                                                                                            count++;
                                                                                                                                        }
                                                                                                                                    }
                                                                                                                                }
                                                                                                                            }
                                                                                                                        }
                                                                                                                    }
                                                                                                                }
                                                                                                            }
                                                                                                        }
                                                                                                    }
                                                                                                }
                                                                                            }
                                                                                        }
                                                                                    }
                                                                                }
                                                                            }
                                                                        }
                                                                    }
                                                                }
                                                            }
                                                        }
                                                    }
                                                }
                                            }

                                        }
                                        }
                                    }
                                }
                            }
                        }
                    }
                }
            }




            Console.WriteLine(count);
        }
    }
}
