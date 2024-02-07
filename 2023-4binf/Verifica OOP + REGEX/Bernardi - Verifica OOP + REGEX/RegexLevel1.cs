using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bernardi___Verifica_OOP___REGEX {
    internal class RegexLevel1 : RegexLevel {
        public RegexLevel1() {

        }

        public override bool Check(string val) {
            return Regex.IsMatch(val, @"^[0-9]*$");
        }
    }
}
