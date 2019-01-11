using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Hogwarts.Model
{
    public class HogwartzSpells
    {
        private string id;
        private string spell;
        private string type;
        private string effect;

        public string Id { get => id; set => id = value; }
        public string Spell { get => spell; set => spell = value; }
        public string Type { get => type; set => type = value; }
        public string Effect { get => effect; set => effect = value; }
    }
}