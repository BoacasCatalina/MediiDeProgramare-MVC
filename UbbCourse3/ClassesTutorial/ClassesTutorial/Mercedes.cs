﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassesTutorial
{
    public class Mercedes:AbstractCar
    {
        public string Description;
        public int Price;
        private string _description;
        private int _price;
        protected string colour;
        protected int year;

        public Mercedes()
        {
            Description = "E Class";
            Price = 67000;
        }

        public int _Price
        {
            get
            {
                return _price;
            }
            set
            {
                _price = 50;
            }
        }
        public string _Description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = "My first car";
            }
        }
    }
}
