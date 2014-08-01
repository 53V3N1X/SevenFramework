﻿// Seven
// https://github.com/53V3N1X/SevenFramework
// LISCENSE: See "LISCENSE.md" in th root project directory.
// SUPPORT: See "SUPPORT.md" in the root project directory.

using System;
using System.Collections;
using System.Collections.Generic;

namespace Seven.Structures
{
  /// <summary>Implements First-In-First-Out queue data structure.</summary>
  /// <typeparam name="Type">The type of items to store in this structure.</typeparam>
  public interface Queue<Type> : Structure<Type>
  {
    #region property

    int Count { get; }
    bool IsEmpty { get; }

    #endregion

    #region method

    void Enqueue(Type push);
    Type Peek();
    Type Dequeue();
    void Clear();

    #endregion
  }

  /// <summary>Implements First-In-First-Out queue data structure.</summary>
  /// <remarks>The runtimes of each public member are included in the "remarks" xml tags.</remarks>
  [Serializable]
  public class Queue_Linked<Type> : Queue<Type>
  {
    #region class

    /// <summary>This class just holds the data for each individual node of the list.</summary>
    private class Node
    {
      private Type _value;
      private Node _next;

      internal Type Value { get { return _value; } set { _value = value; } }
      internal Node Next { get { return _next; } set { _next = value; } }

      internal Node(Type data) { _value = data; }
    }

    #endregion

    #region field

    private Node _head;
    private Node _tail;
    private int _count;

    #endregion

    #region property

    /// <summary>Returns the number of items in the queue.</summary>
    /// <remarks>Runtime: O(1).</remarks>
    public int Count { get { return _count; } }

    /// <summary>Returns true if this structure is in an empty state.</summary>
    public bool IsEmpty { get { return _head == null; } }

    #endregion

    #region construct

    /// <summary>Creates an instance of a queue.</summary>
    /// <remarks>Runtime: O(1).</remarks>
    public Queue_Linked()
    {
      _head = _tail = null;
      _count = 0;
    }

    #endregion

    #region method

    /// <summary>Adds an item to the back of the queue.</summary>
    /// <param name="enqueue">The item to add to the queue.</param>
    /// <remarks>Runtime: O(1).</remarks>
    public void Enqueue(Type enqueue)
    {
      if (_tail == null)
        _head = _tail = new Node(enqueue);
      else
        _tail = _tail.Next = new Node(enqueue);
      _count++;
    }

    /// <summary>Removes the oldest item in the queue.</summary>
    /// <remarks>Runtime: O(1).</remarks>
    public Type Dequeue()
    {
      if (_head == null)
        throw new Exception("Attempting to remove a non-existing id value.");
      Type value = _head.Value;
      if (_head == _tail)
        _tail = null;
      _head = null;
      _count--;
      return value;
    }

    public Type Peek()
    {
      if (_head == null)
        throw new Exception("Attempting to remove a non-existing id value.");
      Type returnValue = _head.Value;
      return returnValue;
    }

    /// <summary>Resets the queue to an empty state.</summary>
    /// <remarks>Runtime: O(1).</remarks>
    public void Clear()
    {
      _head = _tail = null;
      _count = 0;
    }

    /// <summary>Performs a functional paradigm newest-to-oldest traversal of the queue.</summary>
    /// <param name="traversalFunction">The function to perform each iteration.</param>
    /// <remarks>Runtime: O(n * foreachFunction).</remarks>
    public bool TraverseBreakable(Func<Type, bool> traversalFunction)
    {
      Node looper = _head;
      while (looper != null)
      {
        if (!traversalFunction(looper.Value))
          return false;
        looper = looper.Next;
      }
      return true;
    }

    public void Traverse(Action<Type> traversalFunction)
    {
      Node looper = _head;
      while (looper != null)
      {
        traversalFunction(looper.Value);
        looper = looper.Next;
      }
    }

    /// <summary>Converts the list into a standard array.</summary>
    /// <returns>A standard array of all the items.</returns>
    /// /// <remarks>Runtime: Theta(n).</remarks>
    public Type[] ToArray()
    {
      if (_count == 0)
        return null;
      Type[] array = new Type[_count];
      Node looper = _head;
      for (int i = 0; i < _count; i++)
      {
        array[i] = looper.Value;
        looper = looper.Next;
      }
      return array;
    }

    #region .Net Framework Compatibility

    /// <summary>FOR COMPATIBILITY ONLY. AVOID IF POSSIBLE.</summary>
    IEnumerator IEnumerable.GetEnumerator()
    {
      Node current = this._head;
      while (current != null)
      {
        yield return current.Value;
        current = current.Next;
      }
    }

    /// <summary>FOR COMPATIBILITY ONLY. AVOID IF POSSIBLE.</summary>
    IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
    {
      Node current = this._head;
      while (current != null)
      {
        yield return current.Value;
        current = current.Next;
      }
    }

    #endregion

    /// <summary>Gets the current memory imprint of this structure in bytes.</summary>
    /// <remarks>Returns long.MaxValue on overflow.</remarks>
    public int SizeOf { get { throw new NotImplementedException(); } }

    /// <summary>Pulls out all the values in the structure that are equivalent to the key.</summary>
    /// <typeparam name="Key">The type of the key to check for.</typeparam>
    /// <param name="key">The key to check for.</param>
    /// <param name="compare">Delegate representing comparison technique.</param>
    /// <returns>An array containing all the values matching the key or null if non were found.</returns>
    //Type[] GetValues<Key>(Key key, Compare<Type, Key> compare);

    /// <summary>Pulls out all the values in the structure that are equivalent to the key.</summary>
    /// <typeparam name="Key">The type of the key to check for.</typeparam>
    /// <param name="key">The key to check for.</param>
    /// <param name="compare">Delegate representing comparison technique.</param>
    /// <returns>An array containing all the values matching the key or null if non were found.</returns>
    /// <param name="values">The values that matched the given key.</param>
    /// <returns>true if 1 or more values were found; false if no values were found.</returns>
    //bool TryGetValues<Key>(Key key, Compare<Type, Key> compare, out Type[] values);

    /// <summary>Checks to see if a given object is in this data structure.</summary>
    /// <param name="item">The item to check for.</param>
    /// <param name="compare">Delegate representing comparison technique.</param>
    /// <returns>true if the item is in this structure; false if not.</returns>
    public bool Contains(Type item, Compare<Type> compare)
    {
      throw new NotImplementedException();
    }

    /// <summary>Checks to see if a given object is in this data structure.</summary>
    /// <typeparam name="Key">The type of the key to check for.</typeparam>
    /// <param name="key">The key to check for.</param>
    /// <param name="compare">Delegate representing comparison technique.</param>
    /// <returns>true if the item is in this structure; false if not.</returns>
    public bool Contains<Key>(Key key, Compare<Type, Key> compare)
    {
      throw new NotImplementedException();
    }

    /// <summary>Invokes a delegate for each entry in the data structure.</summary>
    /// <param name="function">The delegate to invoke on each item in the structure.</param>
    public void Foreach(Foreach<Type> function)
    {
      Node current = this._head;
      while (current != null)
      {
        function(current.Value);
        current = current.Next;
      }
    }

    /// <summary>Invokes a delegate for each entry in the data structure.</summary>
    /// <param name="function">The delegate to invoke on each item in the structure.</param>
    public void Foreach(ForeachRef<Type> function)
    {
      throw new NotImplementedException();
    }

    /// <summary>Invokes a delegate for each entry in the data structure.</summary>
    /// <param name="function">The delegate to invoke on each item in the structure.</param>
    /// <returns>The resulting status of the iteration.</returns>
    public ForeachStatus Foreach(ForeachBreak<Type> function)
    {
      throw new NotImplementedException();
    }

    /// <summary>Invokes a delegate for each entry in the data structure.</summary>
    /// <param name="function">The delegate to invoke on each item in the structure.</param>
    /// <returns>The resulting status of the iteration.</returns>
    public ForeachStatus Foreach(ForeachRefBreak<Type> function)
    {
      throw new NotImplementedException();
    }

    /// <summary>Creates a shallow clone of this data structure.</summary>
    /// <returns>A shallow clone of this data structure.</returns>
    public Structure<Type> Clone()
    {
      throw new NotImplementedException();
    }

    #endregion

    #region error

    /// <summary>This is used for throwing AVL Tree exceptions only to make debugging faster.</summary>
    private class Exception : Error
    {
      public Exception(string message) : base(message) { }
    }

    #endregion
  }

  /// <summary>Implements a growing list as an array (with expansions/contractions) 
  /// data structure that inherits InterfaceTraversable.</summary>
  /// <typeparam name="Type">The type of objects to be placed in the list.</typeparam>
  /// <remarks>The runtimes of each public member are included in the "remarks" xml tags.</remarks>
  [Serializable]
  public class Queue_Array<Type> : Queue<Type>
  {
    #region fields

    private Type[] _queue;
    private int _start;
    private int _count;
    private int _minimumCapacity;

    #endregion

    #region property

    /// <summary>Gets the number of items in the list.</summary>
    /// <remarks>Runtime: O(1).</remarks>
    public int Count
    {
      get
      {
        int returnValue = _count;
        return returnValue;
      }
    }

    /// <summary>Returns true if the structure is empty.</summary>
    /// <remarks>Runtime: O(1).</remarks>
    public bool IsEmpty { get { return _count == 0; } }

    /// <summary>Gets the current capacity of the list.</summary>
    /// <remarks>Runtime: O(1).</remarks>
    public int CurrentCapacity
    {
      get
      {
        int returnValue = _queue.Length;
        return returnValue;
      }
    }

    /// <summary>Allows you to adjust the minimum capacity of this list.</summary>
    /// <remarks>Runtime: O(n), Omega(1).</remarks>
    public int MinimumCapacity
    {
      get
      {
        int returnValue = _minimumCapacity;
        return returnValue;
      }
      set
      {
        if (value < 1)
          throw new ListArrayException("Attempting to set a minimum capacity to a negative or zero value.");
        else if (value > _queue.Length)
        {
          Type[] newList = new Type[value];
          _queue.CopyTo(newList, 0);
          _queue = newList;
        }
        else
          _minimumCapacity = value;
      }
    }

    #endregion

    #region construct

    /// <summary>Creates an instance of a ListArray, and sets it's minimum capacity.</summary>
    /// <param name="minimumCapacity">The initial and smallest array size allowed by this list.</param>
    /// <remarks>Runtime: O(1).</remarks>
    public Queue_Array(int minimumCapacity)
    {
      _queue = new Type[minimumCapacity];
      _count = 0;
      _minimumCapacity = minimumCapacity;
    }

    #endregion

    #region method

    /// <summary>Adds an item to the end of the list.</summary>
    /// <param name="addition">The item to be added.</param>
    /// <remarks>Runtime: O(n), EstAvg(1). </remarks>
    public void Enqueue(Type addition)
    {
      if (_count == _queue.Length)
      {
        if (_queue.Length > Int32.MaxValue / 2)
        {
          throw new ListArrayException("your queue is so large that it can no longer double itself (Int32.MaxValue barrier reached).");
        }
        Type[] newQueue = new Type[_queue.Length * 2];
        for (int i = 0; i < _count; i++)
          newQueue[i] = _queue[(i + _start) % _queue.Length];
        _start = 0;
        _queue = newQueue;
      }
      _queue[(_start + _count++) % _queue.Length] = addition;
    }

    /// <summary>Removes the item at a specific index.</summary>
    /// <remarks>Runtime: Theta(n - index).</remarks>
    public Type Dequeue()
    {
      if (_count == 0)
        throw new ListArrayException("attempting to dequeue from an empty queue.");
      if (_count < _queue.Length / 4 && _queue.Length / 2 > _minimumCapacity)
      {
        Type[] newQueue = new Type[_queue.Length / 2];
        for (int i = 0; i < _count; i++)
          newQueue[i] = _queue[(i + _start) % _queue.Length];
        _start = 0;
        _queue = newQueue;
      }
      Type returnValue = _queue[_start++];
      _count--;
      if (_count == 0)
        _start = 0;
      return returnValue;
    }

    public Type Peek()
    {
      Type returnValue = _queue[_start];
      return returnValue;
    }

    /// <summary>Empties the list back and reduces it back to its original capacity.</summary>
    /// <remarks>Runtime: O(1).</remarks>
    public void Clear()
    {
      _queue = new Type[_minimumCapacity];
      _count = 0;
    }

    /// <summary>Traverses the structure and performs a function on each entry.</summary>
    /// <param name="traversalFunction">The function within a foreach loop.</param>
    /// <remarks>Runtime: O(n * traversalFunction).</remarks>
    public bool TraverseBreakable(Func<Type, bool> traversalFunction)
    {
      for (int i = 0; i < _count; i++)
        if (!traversalFunction(_queue[i]))
        {
          return false;
        }
      return true;
    }

    /// <summary>Traverses the structure and performs a function on each entry.</summary>
    /// <param name="traversalFunction">The function within a foreach loop.</param>
    /// <param name="start">The index to start the traversal from.</param>
    /// <param name="end">The index to end the traversal at.</param>
    /// <remarks>Runtime: O((end - start) * traversalFunction).</remarks>
    public bool TraverseBreakable(Func<Type, bool> traversalFunction, int start, int end)
    {
      if (start < 0 || start < end || end > _count)
        throw new ListArrayException("invalid index parameters on traversal");
      for (int i = start; i < end; i++)
        if (!traversalFunction(_queue[i]))
        {
          return false;
        }
      return true;
    }

    /// <summary>Traverses the structure and performs an action on each entry.</summary>
    /// <param name="traversalAction">The action within a foreach loop.</param>
    /// <remarks>Runtime: O(n * traversalAction).</remarks>
    public void Traverse(Action<Type> traversalAction)
    {
      for (int i = 0; i < _count; i++) traversalAction(_queue[i]);
    }

    /// <summary>Traverses the structure and performs a function on each entry.</summary>
    /// <param name="traversalAction">The action within a foreach loop.</param>
    /// <param name="start">The index to start the traversal from.</param>
    /// <param name="end">The index to end the traversal at.</param>
    /// <remarks>Runtime: O((end - start) * traversalAction).</remarks>
    public void Traverse(Action<Type> traversalAction, int start, int end)
    {
      if (start < 0 || start < end || end > _count)
        throw new ListArrayException("invalid index parameters on traversal");
      for (int i = start; i < end; i++) traversalAction(_queue[i]);
    }

    /// <summary>Converts the list array into a standard array.</summary>
    /// <returns>A standard array of all the elements.</returns>
    public Type[] ToArray()
    {
      Type[] array = new Type[_count];
      for (int i = 0; i < _count; i++) array[i] = _queue[i];
      return array;
    }

    #region Structure<Type>

    #region .Net Framework Compatibility

    /// <summary>FOR COMPATIBILITY ONLY. AVOID IF POSSIBLE.</summary>
    IEnumerator IEnumerable.GetEnumerator()
    {
      throw new NotImplementedException();
    }

    /// <summary>FOR COMPATIBILITY ONLY. AVOID IF POSSIBLE.</summary>
    IEnumerator<Type> IEnumerable<Type>.GetEnumerator()
    {
      throw new NotImplementedException();
    }

    #endregion

    /// <summary>Gets the current memory imprint of this structure in bytes.</summary>
    /// <remarks>Returns long.MaxValue on overflow.</remarks>
    public int SizeOf { get { throw new NotImplementedException(); } }

    /// <summary>Pulls out all the values in the structure that are equivalent to the key.</summary>
    /// <typeparam name="Key">The type of the key to check for.</typeparam>
    /// <param name="key">The key to check for.</param>
    /// <param name="compare">Delegate representing comparison technique.</param>
    /// <returns>An array containing all the values matching the key or null if non were found.</returns>
    //Type[] GetValues<Key>(Key key, Compare<Type, Key> compare);

    /// <summary>Pulls out all the values in the structure that are equivalent to the key.</summary>
    /// <typeparam name="Key">The type of the key to check for.</typeparam>
    /// <param name="key">The key to check for.</param>
    /// <param name="compare">Delegate representing comparison technique.</param>
    /// <returns>An array containing all the values matching the key or null if non were found.</returns>
    /// <param name="values">The values that matched the given key.</param>
    /// <returns>true if 1 or more values were found; false if no values were found.</returns>
    //bool TryGetValues<Key>(Key key, Compare<Type, Key> compare, out Type[] values);

    /// <summary>Checks to see if a given object is in this data structure.</summary>
    /// <param name="item">The item to check for.</param>
    /// <param name="compare">Delegate representing comparison technique.</param>
    /// <returns>true if the item is in this structure; false if not.</returns>
    public bool Contains(Type item, Compare<Type> compare)
    {
      throw new NotImplementedException();
    }

    /// <summary>Checks to see if a given object is in this data structure.</summary>
    /// <typeparam name="Key">The type of the key to check for.</typeparam>
    /// <param name="key">The key to check for.</param>
    /// <param name="compare">Delegate representing comparison technique.</param>
    /// <returns>true if the item is in this structure; false if not.</returns>
    public bool Contains<Key>(Key key, Compare<Type, Key> compare)
    {
      throw new NotImplementedException();
    }

    /// <summary>Invokes a delegate for each entry in the data structure.</summary>
    /// <param name="function">The delegate to invoke on each item in the structure.</param>
    public void Foreach(Foreach<Type> function)
    {
      throw new NotImplementedException();
    }

    /// <summary>Invokes a delegate for each entry in the data structure.</summary>
    /// <param name="function">The delegate to invoke on each item in the structure.</param>
    public void Foreach(ForeachRef<Type> function)
    {
      throw new NotImplementedException();
    }

    /// <summary>Invokes a delegate for each entry in the data structure.</summary>
    /// <param name="function">The delegate to invoke on each item in the structure.</param>
    /// <returns>The resulting status of the iteration.</returns>
    public ForeachStatus Foreach(ForeachBreak<Type> function)
    {
      throw new NotImplementedException();
    }

    /// <summary>Invokes a delegate for each entry in the data structure.</summary>
    /// <param name="function">The delegate to invoke on each item in the structure.</param>
    /// <returns>The resulting status of the iteration.</returns>
    public ForeachStatus Foreach(ForeachRefBreak<Type> function)
    {
      throw new NotImplementedException();
    }

    /// <summary>Creates a shallow clone of this data structure.</summary>
    /// <returns>A shallow clone of this data structure.</returns>
    public Structure<Type> Clone()
    {
      throw new NotImplementedException();
    }

    ///// <summary>Converts the structure into an array.</summary>
    ///// <returns>An array containing all the item in the structure.</returns>
    //public Type[] ToArray()
    //{
    //  throw new NotImplementedException();
    //}

    #endregion

    #endregion

    #region error

    /// <summary>This is used for throwing AVL Tree exceptions only to make debugging faster.</summary>
    private class ListArrayException : Structure.Error
    {
      public ListArrayException(string message) : base(message) { }
    }

    #endregion
  }
}
