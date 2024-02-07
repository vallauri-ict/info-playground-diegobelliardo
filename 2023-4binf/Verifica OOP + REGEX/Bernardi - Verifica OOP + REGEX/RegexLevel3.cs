using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bernardi___Verifica_OOP___REGEX {
    internal class RegexLevel3 : RegexLevel {
        private string val;
        public RegexLevel3() {

        }

        public override bool Check(string val) {
            return Regex.IsMatch(val, @"^\+39 [0-9]{2} [0-9]{7}$");
        }
    }
}