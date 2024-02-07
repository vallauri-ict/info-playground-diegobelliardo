using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace Bernardi___Verifica_OOP___REGEX {
    internal class RegexLevel4 : RegexLevel {
        public RegexLevel4() {

        }

        public override bool Check(string val) {
            return Regex.IsMatch(val, @"[\w\.]{3,}@\w{3,}\.\w{2,}");
        }
    }
}