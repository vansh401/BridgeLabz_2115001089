using System;

class Task
{
    public int TaskId { get; set; }
    public string TaskName { get; set; }
    public int Priority { get; set; }
    public DateTime DueDate { get; set; }
    public Task Next { get; set; }

    public Task(int taskId, string taskName, int priority, DateTime dueDate)
    {
        TaskId = taskId;
        TaskName = taskName;
        Priority = priority;
        DueDate = dueDate;
        Next = null;
    }

    public override string ToString()
    {
        return $"Task ID: {TaskId}, Name: {TaskName}, Priority: {Priority}, Due Date: {DueDate.ToShortDateString()}";
    }
}

class CircularLinkedList
{
    private Task head;
    private Task current;

    public CircularLinkedList()
    {
        head = null;
        current = null;
    }

    public void AddAtBeginning(Task newTask)
    {
        if (head == null)
        {
            head = newTask;
            head.Next = head;
        }
        else
        {
            Task temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }
            newTask.Next = head;
            head = newTask;
            temp.Next = head;
        }
        current = head;
    }

    public void AddAtEnd(Task newTask)
    {
        if (head == null)
        {
            head = newTask;
            head.Next = head;
        }
        else
        {
            Task temp = head;
            while (temp.Next != head)
            {
                temp = temp.Next;
            }
            temp.Next = newTask;
            newTask.Next = head;
        }
        current = head;
    }

    public void AddAtPosition(Task newTask, int position)
    {
        if (position == 1)
        {
            AddAtBeginning(newTask);
            return;
        }

        Task temp = head;
        int count = 1;

        while (temp.Next != head && count < position - 1)
        {
            temp = temp.Next;
            count++;
        }

        if (count < position - 1)
        {
            Console.WriteLine("Position out of range.");
            return;
        }

        newTask.Next = temp.Next;
        temp.Next = newTask;
        current = head;
    }

    public void RemoveByTaskId(int taskId)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        Task temp = head;
        Task prev = null;

        do
        {
            if (temp.TaskId == taskId)
            {
                if (prev != null)
                {
                    prev.Next = temp.Next;
                }
                else
                {
                    Task last = head;
                    while (last.Next != head)
                    {
                        last = last.Next;
                    }
                    head = temp.Next;
                    last.Next = head;
                }
                current = head;
                return;
            }
            prev = temp;
            temp = temp.Next;
        } while (temp != head);

        Console.WriteLine("Task not found.");
    }

    public void ViewCurrentTask()
    {
        if (current != null)
        {
            Console.WriteLine(current);
            current = current.Next;
        }
        else
        {
            Console.WriteLine("No tasks available.");
        }
    }

    public void DisplayAll()
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        Task temp = head;
        do
        {
            Console.WriteLine(temp);
            temp = temp.Next;
        } while (temp != head);
    }

    public void SearchByPriority(int priority)
    {
        if (head == null)
        {
            Console.WriteLine("List is empty.");
            return;
        }

        Task temp = head;
        bool found = false;

        do
        {
            if (temp.Priority == priority)
            {
                Console.WriteLine(temp);
                found = true;
            }
            temp = temp.Next;
        } while (temp != head);

        if (!found)
        {
            Console.WriteLine("No tasks with the specified priority found.");
        }
    }
}

class TaskScheduler
{
    static void Main()
    {
        CircularLinkedList taskList = new CircularLinkedList();
        
        taskList.AddAtEnd(new Task(1, "Task 1", 3, new DateTime(2025, 5, 1)));
        taskList.AddAtEnd(new Task(2, "Task 2", 1, new DateTime(2025, 4, 1)));
        taskList.AddAtEnd(new Task(3, "Task 3", 2, new DateTime(2025, 6, 1)));

        Console.WriteLine("All Tasks:");
        taskList.DisplayAll();
        Console.WriteLine();

        Console.WriteLine("Viewing current task:");
        taskList.ViewCurrentTask();
        Console.WriteLine();

        Console.WriteLine("Viewing next task:");
        taskList.ViewCurrentTask();
        Console.WriteLine();

        Console.WriteLine("Searching for tasks with Priority 1:");
        taskList.SearchByPriority(1);
        Console.WriteLine();

        Console.WriteLine("Updating task with Task ID 1:");
        taskList.RemoveByTaskId(1);
        taskList.AddAtBeginning(new Task(1, "Updated Task 1", 4, new DateTime(2025, 7, 1)));
        taskList.DisplayAll();
        Console.WriteLine();

        Console.WriteLine("Deleting task with Task ID 2:");
        taskList.RemoveByTaskId(2);
        taskList.DisplayAll();
        Console.WriteLine();
    }
}
