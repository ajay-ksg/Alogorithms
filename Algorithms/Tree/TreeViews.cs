namespace Algorithms.Tree;

public class TreeViews
{
    public List<int> LeftView(DataStructure.Tree tree)
    {
        /*
         * ********************* Approach *************************
         * 1. Do level order traversal (BFS) and print first node of each level
         * 2. Do pre-order traversal and keep track of last printed level
         *      1. if current level > last printed level then only print the node and update last printed level
         * otherwise skip .
         */
        
        // Approach 1
        List<int> leftView = new List<int>();
        Queue<(int,int)> queue = new Queue<(int,int)>();
        int currLevel = 0;
        queue.Enqueue((0, currLevel));
        leftView.Add(tree.ValueAt(0));
        
        while (queue.Count > 0)
        {
            var (nodeIndex, nodeLevel) = queue.Dequeue();
            if (nodeLevel > currLevel)
            {
                leftView.Add(tree.ValueAt(nodeIndex));
                currLevel = nodeLevel;
            }

            var leftChildIndex = 2 * nodeIndex + 1;
            var rightChildIndex = 2 * nodeIndex + 2;
            
            if(tree.ValueAt(leftChildIndex) != DataStructure.Tree.InvalidValue)
                queue.Enqueue((leftChildIndex,currLevel+1)); // left child
            
            if(tree.ValueAt(rightChildIndex) != DataStructure.Tree.InvalidValue)
                queue.Enqueue((2*nodeIndex+2,currLevel+1)); // right child
        }

        return leftView;
    }
}