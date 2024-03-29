﻿using System;
using System.Collections.Generic;
using System.Text;

namespace TemplateDDD.CrossCutting.Utils
{
    public class Sha512
    {
        private string _hash;
        public Sha512(string input)
        {
            var bytes = System.Text.Encoding.UTF8.GetBytes(input);
            using (var hash = System.Security.Cryptography.SHA512.Create())
            {
                var hashedInputBytes = hash.ComputeHash(bytes);

                // Convert to text
                // StringBuilder Capacity is 128, because 512 bits / 8 bits in byte * 2 symbols for byte 
                var hashedInputStringBuilder = new System.Text.StringBuilder(128);
                foreach (var b in hashedInputBytes)
                    hashedInputStringBuilder.Append(b.ToString("X2"));
                _hash = hashedInputStringBuilder.ToString();
            }
        }

        public override string ToString()
        {
            return _hash;
        }
    }
}
