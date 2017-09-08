using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Binary_Tree
{
    class Node
    {
        #region Private
        private int number;

        private Node left;

        private Node right;

        private Node parent;
        #endregion

        #region Properties
        public int Number
        {
            get
            {
                return this.number;
            }

            set
            {
                this.number = value;
            }
        }

        public Node Left
        {
            get
            {
                return this.left;
            }
            set
            {
                this.left = value;
            }
        }

        public Node Right
        {
            get
            {
                return this.right;
            }
            set
            {
                this.right = value;
            }
        }

        public Node Parent
        {
            get
            {
                return this.parent;
            }
            set
            {
                this.parent = value;
            }
        }
        #endregion

        #region Constructor
        public Node()
        {

        }
        #endregion

        #region Methods
        public string Serialize(Node node)
        {
            string path = "";
            string children = "";

            if (node.Left != null)
            {
                path = node.Number + Serialize(node.Left);
            }
            else
            {
                children = node.Number + ".";
            }

            if (node.Right != null)
            {
                path = path + children + Serialize(node.Right);
                return path;
            }
            else
            {
                return children + ".";
            }
        }

        public Node CreateNode(int position = 0, string representation = "8631.2..4..7..9..")
        {
            Node actual = new Node();

            if (position == representation.Length - 1)
            {
                //Node new_node = new Node();
                char character = representation.Substring(position, 1)[0];
                actual.Number = (int)char.GetNumericValue(character);

                actual.Right = CreateNode(position + 1);
                actual.Left = CreateNode(position + 2);

                return actual;
            }
            else
            {
                if (representation.Substring(position, 1) != ".")
                {
                    Node child = new Node();
                    char character2 = representation.Substring(position, 1)[0];
                    child.Number = (int)char.GetNumericValue(character2);
                    return child;
                }
                else
                {
                    actual = CreateNode(position + 1);
                }
                return actual;
            }
        }
        #endregion
    }
}
