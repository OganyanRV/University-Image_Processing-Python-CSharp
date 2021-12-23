﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace laba1
{
    class GaussianFilter : MatrixFilter
    {
        public GaussianFilter()
        {
            CreateGuassianKernel(3, 2);
        }

        public void CreateGuassianKernel(int radius, float sigma)
        {
            int size = 2 * radius + 1;
            kernel = new float[size, size];
            float norm = 0;

            for (int i = -radius; radius >= i; ++i)
            for (int j = -radius; radius >= j; ++j)
            {
                kernel[i + radius, j + radius] = (float)(Math.Exp(-(i * i + j * j) / (2 * sigma * sigma)));
                norm += kernel[i + radius, j + radius];
            }
            for (int i = 0; i < size; ++i)
            for (int j = 0; j < size; ++j)
                kernel[i, j] /= norm;
        }
    }


}