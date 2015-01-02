using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Grafos_Colima
{
    class Node
    {
        private string _nameOfThePlace;
        public string nameOfThePlace
        {
                        get
            {
               return _nameOfThePlace;
            }
        }

        //Builder
        public Node(string name)
        {
            
            _nameOfThePlace = name;
          
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
