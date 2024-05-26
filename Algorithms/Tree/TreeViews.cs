using DataStructure.Tree.ArrayRepresentation;

namespace Algorithms.Tree;

public class TreeViews
{
    /*
     * ********************* Approach *************************
     * 1. Do level order traversal (BFS) and print first node of each level
     * 2. Do pre-order traversal and keep track of last printed level
     *      1. if current level > last printed level then only print the node and update last printed level
     * otherwise skip .
     */
    public List<int?> LeftView(BinaryTree binaryTree)
    {
        // Approach 1
        List<int?> leftView = new List<int?>();
        Queue<(int,int)> queue = new Queue<(int,int)>();
        int currLevel = 0;
        queue.Enqueue((0, currLevel));
        leftView.Add(binaryTree.ValueAt(0));
        
        while (queue.Count > 0)
        {
            var (nodeIndex, nodeLevel) = queue.Dequeue();
            if (nodeLevel > currLevel)
            {
                leftView.Add(binaryTree.ValueAt(nodeIndex));
                currLevel = nodeLevel;
            }

            var leftChildIndex = binaryTree.LeftChildIndexOf(nodeIndex);
            var rightChildIndex = binaryTree.RightChildIndexOf(nodeIndex);
            
            if(binaryTree.ValueAt(leftChildIndex) != BinaryTree.InvalidValue)
                queue.Enqueue((leftChildIndex,currLevel+1)); // left child
            
            if(binaryTree.ValueAt(rightChildIndex) != BinaryTree.InvalidValue)
                queue.Enqueue((2*nodeIndex+2,currLevel+1)); // right child
        }

        return leftView;
    }
}