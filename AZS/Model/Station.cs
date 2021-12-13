using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AZS.Model
{
    public class Station
    {
        [Key]
        public int Station_Id { get; set; }

        private string _address;
        public string Address
        {
            get => _address;
            set
            {
                if ((!string.IsNullOrWhiteSpace(value)) && (value.Length <= 100))
                    _address = value;

            }
        }

    }
}
