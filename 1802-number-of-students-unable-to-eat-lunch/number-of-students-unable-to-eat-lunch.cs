public class Solution {
    public int CountStudents(int[] students, int[] sandwiches) {
        var studentQueue = new Queue<int>(students);
        var sandwichQueue = new Queue<int>(sandwiches);
        int student;

        while(studentQueue.Count > 0)
        {
            if (studentQueue.Peek() == sandwichQueue.Peek())
            {
                studentQueue.Dequeue();
                sandwichQueue.Dequeue();
            }
            else
            {
                student = studentQueue.Peek();
                studentQueue.Dequeue();
                studentQueue.Enqueue(student);
            }

            if (sandwichQueue.Count > 0 && 
                IsUnableToEat(studentQueue, sandwichQueue.Peek()))
            {
                break;
            }
        }   

        return studentQueue.Count; 
    }

    private bool IsUnableToEat(Queue<int> studentQueue, int sandwich)
    {
        if (studentQueue.Count == 0)
        {
            return false;
        }

        return (studentQueue.All(x => x == 0) && sandwich == 1)
            || (studentQueue.All(x => x == 1) && sandwich == 0);
    }
}