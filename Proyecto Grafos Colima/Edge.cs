using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto_Grafos_Colima
{
    class Edge
    {
        private Node _place1; 
        private Node _place2;
        private int _timeLapse;

        public Edge (Node pl, Node pl2, int tiempo)
        {
            _timeLapse = tiempo;
            _place1 = pl;
            _place2 = pl2;

        }
        public Node place1
        {
            get
            {
                return _place1;
            }
        }
        public Node place2
        {
            get
            {
                return _place2;
            }
        }
        public int timeLapse
        {
            get { return _timeLapse; }
        }

        public override string ToString()
        {
            return base.ToString();
        }
    }
}
