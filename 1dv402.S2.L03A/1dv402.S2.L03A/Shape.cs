﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1dv402.S2.L03A
{
    public enum ShapeType
    {
        Ellipse,
        Rectangle,
    }

    class Shape
    {
        private double _length;
        private double _width;

        public abstract double Area
        {
            get;
        }
        
        public double Length
        {
            get { return _length; }
            set 
            {
                if(value <= 0)
                {
                    throw new ArgumentException("Fel! Ange ett tal större än noll.");
                }
                _length = value;
            }
        }

        public abstract double Perimeter
        {
            get;
        }
        
        public double Width
        {
            get { return _width; }
            set 
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Fel! Ange ett tal större än noll.");
                }
                _width = value;
            }
        }


        protected Shape (double length, double width)
        {
        }

        public override string ToString();
        {
            
        }
    }
}