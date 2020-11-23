using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;
using System.Threading;

// Class: IGME-206
// Author: Gage Hubler
// Purpose: Takes the Adjacency Matrix and Adjacency List of a graph, lists all of its vertices by color
//          by a Depth First Search, and performs Dijkstra's shortest path algorithm and prints the results.
//          A Linked List of the result of Dijkstra's algorithm is also implemented and printed.
// Restrictions: None
namespace Test3_Q2
{
    class Program
    {
        static bool[,] mGraph = new bool[,]
{
//            Red       Blue      Cyan      Gray      Orange    Purple    Yellow    Green
/*Red*/     { false   , true    , false   , true    , false   , false   , false   , false },
/*Blue*/    { false   , false   , true    , false   , false   , false   , true    , false },
/*Cyan*/    { false   , true    , false   , true    , false   , false   , false   , false },
/*Gray*/    { false   , false   , true    , false   , true    , false   , false   , false },
/*Orange*/  { false   , false   , false   , false   , false   , true    , false   , false },
/*Purple*/  { false   , false   , false   , false   , false   , false   , true    , false },
/*Yellow*/  { false   , false   , false   , false   , false   , false   , false   , true  },
/*Green*/   { false   , false   , false   , false   , false   , false   , false   , false }
};

        static int[][] lGraph = new int[][]
        {
/*Red*/     new int[] { 1, 3 },
/*Blue*/    new int[] { 2, 6 },
/*Cyan*/    new int[] { 1, 3 },
/*Gray*/    new int[] { 2, 4 },
/*Orange*/  new int[] { 5 },
/*Purple*/  new int[] { 6 },
/*Yellow*/  new int[] { 7 },
/*Green*/   new int[] { }
        };

        static List<Node> game = new List<Node>();

        static LinkedList<Node> colorLinkedList = new LinkedList<Node>();

        static bool bWaitingForMove = false;

        // the current numeric representation of the coin state
        static int nState = 0;

        // the string representation of the desired color state
        static string sUserState = "Red";

        static void Main(string[] args)
        {
            Node node;

            node = new Node(0);
            game.Add(node);

            node = new Node(1);
            game.Add(node);

            node = new Node(2);
            game.Add(node);

            node = new Node(3);
            game.Add(node);

            node = new Node(4);
            game.Add(node);

            node = new Node(5);
            game.Add(node);

            node = new Node(6);
            game.Add(node);

            node = new Node(7);
            game.Add(node);

            game[0].AddEdge(1, game[1]);
            game[0].AddEdge(5, game[3]);
            game[0].edges.Sort();

            game[1].AddEdge(1, game[2]);
            game[1].AddEdge(8, game[6]);
            game[1].edges.Sort();

            game[2].AddEdge(1, game[1]);
            game[2].AddEdge(0, game[3]);
            game[2].edges.Sort();

            game[3].AddEdge(0, game[2]);
            game[3].AddEdge(1, game[4]);
            game[3].edges.Sort();

            game[4].AddEdge(1, game[5]);
            game[4].edges.Sort();

            game[5].AddEdge(1, game[6]);
            game[5].edges.Sort();

            game[6].AddEdge(6, game[7]);
            game[6].edges.Sort();

            List<Node> shortestPath = GetShortestPathDijkstra();

            // the current string representation of the coin state
            string sState;

            // the user-entered numeric representation of the desired coin state
            int nUserState;

            // count how many moves to win
            int nMoves = 0;

            Thread t = new Thread(DFS);
            t.Start();

            Console.WriteLine("Depth First Search: ");

            // while not a winner
            while (nState != 7)
            {
                // convert the current numeric state to a string
                sState = NState2SState(nState);

                // output the current state
                //Console.WriteLine("Current color state: " + sUserState);

                // prompt for the desired state
                //Console.Write("Enter the desired state: ");
                //sUserState = Console.ReadLine().ToUpper();

                bWaitingForMove = true;
                while (bWaitingForMove) ;

                nUserState = SState2NState(sUserState);
                Console.WriteLine(sUserState);


                int[] thisStateList = lGraph[nState];

                if (thisStateList != null)
                {
                    foreach (int n in thisStateList)
                    {
                        if (n == nUserState)
                        {
                            nState = nUserState;
                            ++nMoves;
                            break;
                        }
                    }
                }
            }

            Console.WriteLine("\nShortest path: ");

            // Print each node (converted to string form) contained in shortestPath
            // also, fill the linked list, colorLinkList, for later printing
            foreach (Node n in shortestPath)
            {
                Console.WriteLine(NState2SState(n.nState));

                colorLinkedList.AddLast(n);
            }

            Console.WriteLine("\nLinked List: ");

            // Print each node in colorLinkedList
            foreach (Node n in colorLinkedList)
            {
                Console.WriteLine(NState2SState(n.nState));
            }
        }

        // convert the string to the equivalent integer
        static int SState2NState(string sState)
        {
            int nState = 0;

            switch (sState)
            {
                case "Red":
                    nState = 0;
                    break;
                case "Blue":
                    nState = 1;
                    break;
                case "Cyan":
                    nState = 2;
                    break;
                case "Gray":
                    nState = 3;
                    break;
                case "Orange":
                    nState = 4;
                    break;
                case "Purple":
                    nState = 5;
                    break;
                case "Yellow":
                    nState = 6;
                    break;
                case "Green":
                    nState = 7;
                    break;
            }

            return (nState);
        }

        // convert the integer to the equivalent string
        static string NState2SState(int nState)
        {
            string r = null;

            switch (nState)
            {
                case 0:
                    r = "Red";
                    break;
                case 1:
                    r = "Blue";
                    break;
                case 2:
                    r = "Cyan";
                    break;
                case 3:
                    r = "Gray";
                    break;
                case 4:
                    r = "Orange";
                    break;
                case 5:
                    r = "Purple";
                    break;
                case 6:
                    r = "Yellow";
                    break;
                case 7:
                    r = "Green";
                    break;
            }

            return (r);
        }

        // A function used by DFS 
        static void DFSUtil(int v, bool[] visited)
        {
            while (!bWaitingForMove) ;

            // Mark the current node as visited 
            // and print it 
            visited[v] = true;

            sUserState = NState2SState(v);
            //Console.Write(v + " ");

            bWaitingForMove = false;

            // Recur for all the vertices 
            // adjacent to this vertex 
            int[] thisStateList = lGraph[v];
            foreach (int n in thisStateList)
            {
                if (!visited[n])
                {
                    DFSUtil(n, visited);
                }
            }
        }
        
        // The function to do DFS traversal. 
        // It uses recursive DFSUtil() 
        static void DFS()
        {
            // Mark all the vertices as not visited 
            // (set as false by default in c#) 
            bool[] visited = new bool[lGraph.Length];

            // Call the recursive helper function 
            // to print DFS traversal 
            DFSUtil(nState, visited);
        }

        static public List<Node> GetShortestPathDijkstra()
        {
            DijkstraSearch();
            List<Node> shortestPath = new List<Node>();
            shortestPath.Add(game[7]);
            BuildShortestPath(shortestPath, game[7]);
            shortestPath.Reverse();
            return (shortestPath);
        }

        static private void BuildShortestPath(List<Node> list, Node node)
        {
            if (node.nearestToStart == null)
            {
                return;
            }

            list.Add(node.nearestToStart);
            BuildShortestPath(list, node.nearestToStart);
        }

        static private int NodeOrderBy(Node n)
        {
            return n.minCostToStart;
        }

        static private void DijkstraSearch()
        {
            Node start = game[0];

            start.minCostToStart = 0;
            List<Node> prioQueue = new List<Node>();
            prioQueue.Add(start);

            do
            {
                // sort our prioQueue by minCostToStart
                // option #1, use .Sort() which sorts in place
                // and uses the overloaded Node.CompareTo() method
                prioQueue.Sort();

                // option #2, use .OrderBy() with a delegate method or lambda expression 
                // to indicate which field to sort by
                // the next 5 lines are equivalent from descriptive to abbreviated:
                prioQueue = prioQueue.OrderBy(delegate (Node n) { return n.minCostToStart; }).ToList();
                prioQueue = prioQueue.OrderBy((Node n) => { return n.minCostToStart; }).ToList();
                prioQueue = prioQueue.OrderBy((n) => { return n.minCostToStart; }).ToList();
                prioQueue = prioQueue.OrderBy((n) => n.minCostToStart).ToList();
                prioQueue = prioQueue.OrderBy(n => n.minCostToStart).ToList();

                Node node = prioQueue.First();
                prioQueue.Remove(node);
                foreach (Edge cnn in node.edges)
                //.OrderBy(delegate(Edge n) { return n.cost; }))
                {
                    Node childNode = cnn.connectedNode;
                    if (childNode.visited)
                    {
                        continue;
                    }

                    if (childNode.minCostToStart == int.MaxValue ||
                        node.minCostToStart + cnn.cost < childNode.minCostToStart)
                    {
                        childNode.minCostToStart = node.minCostToStart + cnn.cost;
                        childNode.nearestToStart = node;
                        if (!prioQueue.Contains(childNode))
                        {
                            prioQueue.Add(childNode);
                        }
                    }
                }

                node.visited = true;

                if (node == game[7])
                {
                    return;
                }
            } while (prioQueue.Any());
        }
    }

    public class Node : IComparable<Node>
    {
        public int nState;
        public List<Edge> edges = new List<Edge>();

        public int minCostToStart;
        public Node nearestToStart;
        public bool visited;

        public Node(int nState)
        {
            this.nState = nState;
            this.minCostToStart = int.MaxValue;
        }


        internal class _Node
        {
            internal int data;
            internal _Node next;
            public _Node(int d)
            {
                data = d;
                next = null;
            }
        }

        internal class SingleLinkedList
        {
            internal _Node head;
        }

        internal void InsertLast(SingleLinkedList singlyList, int new_data)
        {
            _Node new_node = new _Node(new_data);
            if (singlyList.head == null)
            {
                singlyList.head = new_node;
                return;
            }
            _Node lastNode = GetLastNode(singlyList);
            lastNode.next = new_node;
        }

        internal _Node GetLastNode(SingleLinkedList singlyList)
        {
            _Node temp = singlyList.head;
            while (temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        public void AddEdge(int cost, Node connection)
        {
            Edge e = new Edge(cost, connection);
            edges.Add(e);
        }

        public int CompareTo(Node n)
        {
            return this.minCostToStart.CompareTo(n.minCostToStart);
        }
    }

    public class Edge : IComparable<Edge>
    {
        public int cost;
        public Node connectedNode;

        public Edge(int cost, Node connectedNode)
        {
            this.cost = cost;
            this.connectedNode = connectedNode;
        }

        public int CompareTo(Edge e)
        {
            return this.cost.CompareTo(e.cost);
        }
    }

}
