using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Algorithm
{
    public class BinaryTree
    {
        public TreeNode root;
        public int count;

        public void Add(TreeNode newNode, ref TreeNode   binaryTree)
        {
           
            if (binaryTree == null)
            {
                binaryTree = newNode;
            }
            else
            {
                if (newNode.value < binaryTree.value) Add(newNode, ref binaryTree.left);
                else Add(newNode, ref binaryTree.right);
            }
        }

        public TreeNode Insert(int value)
        {
            TreeNode newNode = new TreeNode(value);

            try
            {
                if (root == null)
                {
                    root = newNode;
                }
                else
                {
                    Add(newNode, ref root);
                    count++;
                }
                return newNode;

            }
            catch (Exception)
            {
                return null;
            }
        }

        public string  DrawNodePrefix(TreeNode node)
        {
            if(node==null)
            {
               return "Empty Node";
            }
            if ((node.right == null) && (node.left == null))
            {
                return $"{node.value}";
            }
            if((node.left != null) && (node.right == null))
            {
                return $"{node.value} ({DrawNodePrefix(node.left)},_)";
            }
            if ((node.right != null) && (node.left == null))
            {
                return $"{node.right} (_,{DrawNodePrefix(node.right)})";
            }

            return node.value + "(" + DrawNodePrefix(node.left) + ", " + DrawNodePrefix(node.right) + ")";
        }
        public string DrawNodePostfix(TreeNode node)
        {
                if (node == null)
                {
                    return "Empty Node";
                }
                if ((node.left != null) && (node.right == null))
                {
                    return $"{node.value} ({DrawNodePostfix(node.left)},_)";
                }
                if ((node.right != null) && (node.left == null))
                {
                    return $"{node.right} (_,{DrawNodePostfix(node.right)})";
                }
                if ((node.right == null) && (node.left == null))
                {
                    return $"{node.value}";
                }
                
            return  "(" + DrawNodePostfix(node.left) + ", " + DrawNodePostfix(node.right) + ")"+ node.value ;
        }
        public string DrawNodeInfix(TreeNode node)
        {
            if (node == null)
            {
                return "Empty Node";
            }
            if ((node.left != null) && (node.right == null))
            {
                return $"{node.value} ({DrawNodeInfix(node.left)},_)";
            }

            if ((node.right == null) && (node.left == null))
            {
                return $"{node.value}";
            }
            if ((node.right != null) && (node.left == null))
            {
                return $"{node.right} (_,{DrawNodeInfix(node.right)})";
            }

            

            return "(" + DrawNodeInfix(node.left) + $",Parent: {node.value} ," + DrawNodeInfix(node.right) + ")" ;
        }

        public TreeNode Find(int value)
        {
            if (root == null)
            {
                return null;
            }
            TreeNode tmp = root;
            while (tmp != null)
            {
                if (tmp.value == value)
                {
                    return tmp;
                }

                if (value < tmp.value) tmp = root.left;
                else tmp = root.right ;
            }
            return tmp;
        }

        public string DrawTree()
        {
            return DrawNodeInfix(root);
        }
        //public static void Main()
        //{
        //    var nom = "aaa";
        //    var hashCode = (int)nom.GetHashCode()%10;

        //    Console.WriteLine();
        //    //TreeNode root = new TreeNode(6);
        //    //BinaryTree tree = new BinaryTree() { root = root };
        //    //tree.Insert(4);
        //    //tree.Insert(3);
        //    //tree.Insert(5);
        //    //tree.Insert(8);
        //    //tree.Insert(7);
        //    //tree.Insert(9);
        //    //Console.WriteLine( tree.DrawTree());

        //    //var leaf = tree.Find(8);
        //}
    }
}
