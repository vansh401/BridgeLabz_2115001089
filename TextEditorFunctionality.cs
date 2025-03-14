using System;

class TextState
{
    public string Content;
    public TextState Prev;
    public TextState Next;

    public TextState(string content)
    {
        Content = content;
        Prev = null;
        Next = null;
    }
}

class TextEditor
{
    private TextState head;
    private TextState current;
    private int maxStates = 10;
    private int stateCount = 0;

    public void AddState(string text)
    {
        TextState newState = new TextState(text);

        if (current != null)
        {
            current.Next = newState;
            newState.Prev = current;
        }
        else
        {
            head = newState;
        }

        current = newState;
        stateCount++;

        if (stateCount > maxStates)
        {
            head = head.Next;
            head.Prev = null;
            stateCount--;
        }
    }

    public void Undo()
    {
        if (current != null && current.Prev != null)
        {
            current = current.Prev;
        }
    }

    public void Redo()
    {
        if (current != null && current.Next != null)
        {
            current = current.Next;
        }
    }

    public void DisplayCurrentState()
    {
        if (current != null)
        {
            Console.WriteLine("Current text: " + current.Content);
        }
        else
        {
            Console.WriteLine("No text available");
        }
    }
}

class TextEditorFunctionality
{
    static void Main()
    {
        TextEditor editor = new TextEditor();

        editor.AddState("hello");
        editor.AddState("helloapp");
        editor.AddState("helloapp!");

        editor.DisplayCurrentState();
        editor.Undo();
        editor.DisplayCurrentState();
        editor.Undo();
        editor.DisplayCurrentState();
        editor.Redo();
        editor.DisplayCurrentState();
    }
}