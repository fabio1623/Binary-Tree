using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class Node_by_franck
    {
        public string strBidon = "Je ne sais pas quoi faire en exemple";
        public string nodeRepresentation = "8631.2..4..7..9..";

        public string RecurseStr(int position = 0)
        {
            string actual = "";

            if (position < (strBidon.Length - 1))
            {
                actual = RecurseStr(position+1) + strBidon.Substring(position, 1);
                return actual;
            }
            else
            {
                return strBidon.Substring(position, 1);
            }
        }

        public string ShowStr(int position = 0)
        {
            string actual = "";

            if (position == nodeRepresentation.Length - 1)
            {
                if (nodeRepresentation.Substring(position, 1) == ".")
                {
                    return "";
                }
                else
                {
                    return nodeRepresentation.Substring(position, 1);
                }
            }
            else
            {
                if (nodeRepresentation.Substring(position, 1) == ".")
                {
                    actual = ShowStr(position + 1);
                }
                else
                {
                    actual = nodeRepresentation.Substring(position, 1) + ShowStr(position + 1);
                }
                return actual;
            }
        }

    }
}
