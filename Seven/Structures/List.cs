﻿using System;
using System.Threading;

namespace Seven.Structures
{
  public interface List<Type> //: Structure<Type>
  {
    void Add(Type addition);
    //void RemoveFirst(Type removal, Compare<Type> compare);
    //bool TryRemoveFirst(Type removal, Compare<Type> compare);
    //Type GetFirst<Key>(Key key, Compare<Type, Key> compare);
    //bool TryGetFirst<Key>(Key key, Compare<Type, Key> compare, out Type item);

    int Count { get; }
    bool IsEmpty { get; }
    void Clear();


    //bool Contains<Key>(Key key, Func<Type, Key, int> comparison);
    //Type Get<Key>(Key key, Func<Type, Key, int> comparison);
    //bool TryGet<Key>(Key key, Func<Type, Key, int> comparison, out Type item);
    //void RemoveFirst<Key>(Key key, Func<Type, Key, int> comparison);
    //bool TryRemoveFirst<Key>(Key key, Func<Type, Key, int> comparison);
  }

  /// <summary>Implements a growing, singularly-linked list data structure that inherits InterfaceTraversable.</summary>
  /// <typeparam name="InterfaceStringId">The type of objects to be placed in the list.</typeparam>
  /// <remarks>The runtimes of each public member are included in the "remarks" xml tags.</remarks>
  [Serializable]
  public class List_Linked<Type> : List<Type>
  {
    /// <summary>This class just holds the data for each individual node of the list.</summary>
    protected class Node
    {
      private Type _value;
      private Node _next;

      internal Type Value { get { return _value; } set { _value = value; } }
      internal Node Next { get { return _next; } set { _next = value; } }

      internal Node(Type data) { _value = data; }
    }

    protected Node _head;
    protected Node _tail;
    protected int _count;

    /// <summary>Returns the number of items in the list.</summary>
    /// <remarks>Runtime: O(1).</remarks>
    public int Count { get { return _count; } }

    /// <summary>Returns true if the structure is empty.</summary>
    /// <remarks>Runtime: O(1).</remarks>
    public bool IsEmpty { get { return _count == 0; } }

    /// <summary>Creates an instance of a stalistck.</summary>
    /// <remarks>Runtime: O(1).</remarks>
    public List_Linked()
    {
      _head = _tail = null;
      _count = 0;
    }

    /// <summary>Checks to see if an object reference exists.</summary>
    /// <param name="itemReference">The reference to the object.</param>
    /// <returns>Whether or not the object reference was found.</returns>
    public bool Contains(Type itemReference)
    {
      for (Node looper = _head; looper != null; looper = looper.Next)
        if (looper.Value.Equals(itemReference))
          return true;
      return false;
    }

    /// <summary>Adds an item to the list.</summary>
    /// <param name="id">The string id of the item to add to the list.</param>
    /// <param name="addition">The item to add to the list.</param>
    /// <remarks>Runtime: O(1).</remarks>
    public void Add(Type addition)
    {
      if (_tail == null)
        _head = _tail = new Node(addition);
      else
        _tail = _tail.Next = new Node(addition);
      _count++;
    }

    /// <summary>Removes the first equality by object reference.</summary>
    /// <param name="removal">The reference to the item to remove.</param>
    public void RemoveFirst(Type removal)
    {
      if (_head == null)
        throw new ListLinkedException("Attempting to remove a non-existing id value.");
      if (_head.Value.Equals(removal))
      {
        _head = _head.Next;
        _count--;
        return;
      }
      Node listNode = _head;
      while (listNode != null)
      {
        if (listNode.Next == null)
          throw new ListLinkedException("Attempting to remove a non-existing id value.");
        else if (_head.Value.Equals(removal))
        {
          if (listNode.Next.Equals(_tail))
            _tail = listNode;
          listNode.Next = listNode.Next.Next;
          return;
        }
        else
          listNode = listNode.Next;
      }
      throw new ListLinkedException("Attempting to remove a non-existing id value.");
    }

    /// <summary>Resets the list to an empty state. WARNING could cause excessive garbage collection.</summary>
    public void Clear()
    {
      _head = _tail = null;
      _count = 0;
    }

    ///// <summary>Allows a foreach loop using a delegate.</summary>
    ///// <param name="traversalFunction">The function to perform on each iteration.</param>
    ///// <remarks>Runtime: O(n * traversalFunction).</remarks>
    //public bool TraverseBreakable(Func<Type, bool> traversalFunction)
    //{
    //  Node looper = _head;
    //  while (looper != null)
    //  {
    //    if (!traversalFunction(looper.Value))
    //      return false;
    //    looper = looper.Next;
    //  }
    //  return true;
    //}

    ///// <summary>Does an imperative traversal of the structure.</summary>
    ///// <param name="traversalAction">The action to perform on each iteration.</param>
    ///// <remarks>Runtime: O(n * traversalAction).</remarks>
    //public void Traverse(Action<Type> traversalAction)
    //{
    //  Node looper = _head;
    //  while (looper != null)
    //  {
    //    traversalAction(looper.Value);
    //    looper = looper.Next;
    //  }
    //}

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

    /// <summary>This is used for throwing AVL Tree exceptions only to make debugging faster.</summary>
    protected class ListLinkedException : Exception { public ListLinkedException(string message) : base(message) { } }
  }

  #region ListLinkedThreadSafe<Type>

  ///// <summary>Implements a growing, singularly-linked list data structure that inherits InterfaceTraversable.</summary>
  ///// <typeparam name="InterfaceStringId">The type of objects to be placed in the list.</typeparam>
  ///// <remarks>The runtimes of each public member are included in the "remarks" xml tags.</remarks>
  //[Serializable]
  //public class ListLinkedThreadSafe<Type> : List<Type>
  //{
  //  #region ListLinkedNode

  //  /// <summary>This class just holds the data for each individual node of the list.</summary>
  //  protected class ListLinkedThreadSafeNode
  //  {
  //    private Type _value;
  //    private ListLinkedThreadSafeNode _next;

  //    internal Type Value { get { return _value; } set { _value = value; } }
  //    internal ListLinkedThreadSafeNode Next { get { return _next; } set { _next = value; } }

  //    internal ListLinkedThreadSafeNode(Type data) { _value = data; }
  //  }

  //  #endregion

  //  protected ListLinkedThreadSafeNode _head;
  //  protected ListLinkedThreadSafeNode _tail;
  //  protected int _count;

  //  protected object _lock;
  //  protected int _readers;
  //  protected int _writers;

  //  /// <summary>Returns the number of items in the list.</summary>
  //  /// <remarks>Runtime: O(1).</remarks>
  //  public int Count { get { ReaderLock(); int count = _count; ReaderUnlock(); return count; } }

  //  /// <summary>Returns true if the structure is empty.</summary>
  //  /// <remarks>Runtime: O(1).</remarks>
  //  public bool IsEmpty { get { return _count == 0; } }

  //  /// <summary>Creates an instance of a stalistck.</summary>
  //  /// <remarks>Runtime: O(1).</remarks>
  //  public ListLinkedThreadSafe()
  //  {
  //    _head = _tail = null;
  //    _count = 0;
  //    _lock = new object();
  //    _readers = 0;
  //    _writers = 0;
  //  }

  //  /// <summary>Checks to see if an object reference exists.</summary>
  //  /// <param name="itemReference">The reference to the object.</param>
  //  /// <returns>Whether or not the object reference was found.</returns>
  //  public bool Contains(Type itemReference)
  //  {
  //    for (ListLinkedThreadSafeNode looper = _head; looper != null; looper = looper.Next)
  //      if (looper.Value.Equals(itemReference))
  //        return true;
  //    return false;
  //  }

  //  /// <summary>Adds an item to the list.</summary>
  //  /// <param name="id">The string id of the item to add to the list.</param>
  //  /// <param name="addition">The item to add to the list.</param>
  //  /// <remarks>Runtime: O(1).</remarks>
  //  public void Add(Type addition)
  //  {
  //    WriterLock();
  //    if (_tail == null)
  //      _head = _tail = new ListLinkedThreadSafeNode(addition);
  //    else
  //      _tail = _tail.Next = new ListLinkedThreadSafeNode(addition);
  //    _count++;
  //    WriterUnlock();
  //  }

  //  /// <summary>Removes the first equality by object reference.</summary>
  //  /// <param name="removal">The reference to the item to remove.</param>
  //  public void RemoveFirst(Type removal)
  //  {
  //    WriterLock();
  //    if (_head == null)
  //      throw new ListLinkedException("Attempting to remove a non-existing id value.");
  //    if (_head.Value.Equals(removal))
  //    {
  //      _head = _head.Next;
  //      _count--;
  //      WriterUnlock();
  //      return;
  //    }
  //    ListLinkedThreadSafeNode listNode = _head;
  //    while (listNode != null)
  //    {
  //      if (listNode.Next == null)
  //      {
  //        WriterUnlock();
  //        throw new ListLinkedException("Attempting to remove a non-existing id value.");
  //      }
  //      else if (_head.Value.Equals(removal))
  //      {
  //        if (listNode.Next.Equals(_tail))
  //          _tail = listNode;
  //        listNode.Next = listNode.Next.Next;
  //        WriterUnlock();
  //        return;
  //      }
  //      else
  //        listNode = listNode.Next;
  //    }
  //    WriterUnlock();
  //    throw new ListLinkedException("Attempting to remove a non-existing id value.");
  //  }

  //  /// <summary>Resets the list to an empty state. WARNING could cause excessive garbage collection.</summary>
  //  public void Clear()
  //  {
  //    WriterLock();
  //    _head = _tail = null;
  //    _count = 0;
  //    WriterUnlock();
  //  }

  //  /// <summary>Allows a foreach loop using a delegate.</summary>
  //  /// <param name="traversalFunction">The function to perform on each iteration.</param>
  //  /// <remarks>Runtime: O(n * traversalFunction).</remarks>
  //  public bool TraverseBreakable(Func<Type, bool> traversalFunction)
  //  {
  //    ReaderLock();
  //    ListLinkedThreadSafeNode looper = _head;
  //    while (looper != null)
  //    {
  //      if (!traversalFunction(looper.Value))
  //      {
  //        ReaderUnlock();
  //        return false;
  //      }
  //      looper = looper.Next;
  //    }
  //    ReaderUnlock();
  //    return true;
  //  }

  //  /// <summary>Does an imperative traversal of the structure.</summary>
  //  /// <param name="traversalAction">The action to perform on each iteration.</param>
  //  /// <remarks>Runtime: O(n * traversalAction).</remarks>
  //  public void Traverse(Action<Type> traversalAction)
  //  {
  //    ReaderLock();
  //    ListLinkedThreadSafeNode looper = _head;
  //    while (looper != null)
  //    {
  //      traversalAction(looper.Value);
  //      looper = looper.Next;
  //    }
  //    ReaderUnlock();
  //  }

  //  /// <summary>Converts the list into a standard array.</summary>
  //  /// <returns>A standard array of all the items.</returns>
  //  /// /// <remarks>Runtime: Theta(n).</remarks>
  //  public Type[] ToArray()
  //  {
  //    ReaderLock();
  //    if (_count == 0)
  //    {
  //      ReaderUnlock();
  //      return null;
  //    }
  //    Type[] array = new Type[_count];
  //    ListLinkedThreadSafeNode looper = _head;
  //    for (int i = 0; i < _count; i++)
  //    {
  //      array[i] = looper.Value;
  //      looper = looper.Next;
  //    }
  //    ReaderUnlock();
  //    return array;
  //  }

  //  /// <summary>Thread safe enterance for readers.</summary>
  //  protected void ReaderLock() { }// lock (_lock) { while (!(_writers == 0)) Monitor.Wait(_lock); _readers++; } }
  //  /// <summary>Thread safe exit for readers.</summary>
  //  protected void ReaderUnlock() { }// lock (_lock) { _readers--; Monitor.Pulse(_lock); } }
  //  /// <summary>Thread safe enterance for writers.</summary>
  //  protected void WriterLock() { } //lock (_lock) { while (!(_writers == 0) && !(_readers == 0)) Monitor.Wait(_lock); _writers++; } }
  //  /// <summary>Thread safe exit for readers.</summary>
  //  protected void WriterUnlock() { } //lock (_lock) { _writers--; Monitor.PulseAll(_lock); } }

  //  /// <summary>This is used for throwing AVL Tree exceptions only to make debugging faster.</summary>
  //  protected class ListLinkedException : Exception { public ListLinkedException(string message) : base(message) { } }
  //}

  #endregion

  #region ListArray<Type>

  ///// <summary>Implements a growing list as an array (with expansions/contractions) 
  ///// data structure that inherits InterfaceTraversable.</summary>
  ///// <typeparam name="Type">The type of objects to be placed in the list.</typeparam>
  ///// <remarks>The runtimes of each public member are included in the "remarks" xml tags.</remarks>
  //[Serializable]
  //public class ListArray<Type> : List<Type>
  //{
  //  protected Type[] _list;
  //  protected int _count;
  //  protected int _minimumCapacity;

  //  // This value determines the starting data structure size
  //  // at which my traversal functions will begin dynamic multithreading
  //  protected object _lock;
  //  protected int _readers;
  //  protected int _writers;

  //  /// <summary>Gets the number of items in the list.</summary>
  //  /// <remarks>Runtime: O(1).</remarks>
  //  public int Count
  //  {
  //    get
  //    {
  //      ReaderLock();
  //      int returnValue = _count;
  //      ReaderUnlock();
  //      return returnValue;
  //    }
  //  }

  //  /// <summary>Returns true if the structure is empty.</summary>
  //  /// <remarks>Runtime: O(1).</remarks>
  //  public bool IsEmpty { get { return _count == 0; } }

  //  /// <summary>Gets the current capacity of the list.</summary>
  //  /// <remarks>Runtime: O(1).</remarks>
  //  public int CurrentCapacity
  //  {
  //    get
  //    {
  //      ReaderLock();
  //      int returnValue = _list.Length;
  //      ReaderUnlock();
  //      return returnValue;
  //    }
  //  }

  //  /// <summary>Allows you to adjust the minimum capacity of this list.</summary>
  //  /// <remarks>Runtime: O(n), Omega(1).</remarks>
  //  public int MinimumCapacity
  //  {
  //    get
  //    {
  //      ReaderLock();
  //      int returnValue = _minimumCapacity;
  //      ReaderUnlock();
  //      return returnValue;
  //    }
  //    set
  //    {
  //      WriterLock();
  //      if (value < 1)
  //        throw new ListArrayException("Attempting to set a minimum capacity to a negative or zero value.");
  //      else if (value > _list.Length)
  //      {
  //        Type[] newList = new Type[value];
  //        _list.CopyTo(newList, 0);
  //        _list = newList;
  //      }
  //      else
  //        _minimumCapacity = value;
  //      WriterUnlock();
  //    }
  //  }

  //  /// <summary>Look-up and set an indexed item in the list.</summary>
  //  /// <param name="index">The index of the item to get or set.</param>
  //  /// <returns>The value at the given index.</returns>
  //  public Type this[int index]
  //  {
  //    get
  //    {
  //      ReaderLock();
  //      if (index < 0 || index > _count)
  //      {
  //        ReaderUnlock();
  //        throw new ListArrayException("Attempting an index look-up outside the ListArray's current size.");
  //      }
  //      Type returnValue = _list[index];
  //      ReaderUnlock();
  //      return returnValue;
  //    }
  //    set
  //    {
  //      WriterLock();
  //      if (index < 0 || index > _count)
  //      {
  //        WriterUnlock();
  //        throw new ListArrayException("Attempting an index assignment outside the ListArray's current size.");
  //      }
  //      _list[index] = value;
  //      WriterUnlock();
  //    }
  //  }

  //  /// <summary>Creates an instance of a ListArray, and sets it's minimum capacity.</summary>
  //  /// <param name="minimumCapacity">The initial and smallest array size allowed by this list.</param>
  //  /// <remarks>Runtime: O(1).</remarks>
  //  public ListArray(int minimumCapacity)
  //  {
  //    _list = new Type[minimumCapacity];
  //    _count = 0;
  //    _minimumCapacity = minimumCapacity;
  //    _lock = new object();
  //    _readers = 0;
  //    _writers = 0;
  //  }

  //  /// <summary>Determines if an object reference exists in the array.</summary>
  //  /// <param name="reference">The reference to the object.</param>
  //  /// <returns>Whether or not the object reference exists.</returns>
  //  public bool Contains(Type reference)
  //  {
  //    for (int i = 0; i < _count; i++)
  //      if (_list[i].Equals(reference))
  //        return true;
  //    return false;
  //  }

  //  /// <summary>Adds an item to the end of the list.</summary>
  //  /// <param name="addition">The item to be added.</param>
  //  /// <remarks>Runtime: O(n), EstAvg(1). </remarks>
  //  public void Add(Type addition)
  //  {
  //    WriterLock();
  //    if (_count == _list.Length)
  //    {
  //      if (_list.Length > Int32.MaxValue / 2)
  //        throw new ListArrayException("Your list is so large that it can no longer double itself (Int32.MaxValue barrier reached).");
  //      Type[] newList = new Type[_list.Length * 2];
  //      _list.CopyTo(newList, 0);
  //      _list = newList;
  //    }
  //    _list[_count++] = addition;
  //    WriterUnlock();
  //  }

  //  /// <summary>Removes the item at a specific index.</summary>
  //  /// <param name="index">The index of the item to be removed.</param>
  //  /// <remarks>Runtime: Theta(n - index).</remarks>
  //  public void Remove(int index)
  //  {
  //    WriterLock();
  //    if (index < 0 || index > _count)
  //      throw new ListArrayException("Attempting to remove an index outside the ListArray's current size.");
  //    if (_count < _list.Length / 4 && _list.Length / 2 > _minimumCapacity)
  //    {
  //      Type[] newList = new Type[_list.Length / 2];
  //      for (int i = 0; i < _count; i++)
  //        newList[i] = _list[i];
  //      _list = newList;
  //    }
  //    for (int i = index; i < _count; i++)
  //      _list[i] = _list[i + 1];
  //    _count--;
  //    WriterUnlock();
  //  }

  //  /// <summary>Removes the first equality by object reference.</summary>
  //  /// <param name="removal">The reference to the item to remove.</param>
  //  public void RemoveFirst(Type removal)
  //  {
  //    WriterLock();
  //    for (int index = 0; index < _count; index++)
  //      if (_list[index].Equals(removal))
  //      {
  //        if (_count < _list.Length / 4 && _list.Length / 2 > _minimumCapacity)
  //        {
  //          Type[] newList = new Type[_list.Length / 2];
  //          for (int i = 0; i < _count; i++)
  //            newList[i] = _list[i];
  //          _list = newList;
  //        }
  //        for (int i = index; i < _count - 1; i++)
  //          _list[i] = _list[i + 1];
  //        _count--;
  //        WriterUnlock();
  //        return;
  //      }
  //    WriterUnlock();
  //    throw new ListArrayException("attempting to remove a non-existing value.");
  //  }

  //  /// <summary>Empties the list back and reduces it back to its original capacity.</summary>
  //  /// <remarks>Runtime: O(1).</remarks>
  //  public void Clear()
  //  {
  //    WriterLock();
  //    _list = new Type[_minimumCapacity];
  //    _count = 0;
  //    WriterUnlock();
  //  }

  //  /// <summary>Traverses the structure and performs a function on each entry.</summary>
  //  /// <param name="traversalFunction">The function within a foreach loop.</param>
  //  /// <remarks>Runtime: O(n * traversalFunction).</remarks>
  //  public bool TraverseBreakable(Func<Type, bool> traversalFunction)
  //  {
  //    ReaderLock();
  //    for (int i = 0; i < _count; i++)
  //      if (!traversalFunction(_list[i]))
  //      {
  //        ReaderUnlock();
  //        return false;
  //      }
  //    ReaderUnlock();
  //    return true;
  //  }

  //  /// <summary>Traverses the structure and performs a function on each entry.</summary>
  //  /// <param name="traversalFunction">The function within a foreach loop.</param>
  //  /// <param name="start">The index to start the traversal from.</param>
  //  /// <param name="end">The index to end the traversal at.</param>
  //  /// <remarks>Runtime: O((end - start) * traversalFunction).</remarks>
  //  public bool TraverseBreakable(Func<Type, bool> traversalFunction, int start, int end)
  //  {
  //    if (start < 0 || start < end || end > _count)
  //      throw new ListArrayException("invalid index parameters on traversal");
  //    ReaderLock();
  //    for (int i = start; i < end; i++)
  //      if (!traversalFunction(_list[i]))
  //      {
  //        ReaderUnlock();
  //        return false;
  //      }
  //    ReaderUnlock();
  //    return true;
  //  }

  //  /// <summary>Traverses the structure and performs an action on each entry.</summary>
  //  /// <param name="traversalAction">The action within a foreach loop.</param>
  //  /// <remarks>Runtime: O(n * traversalAction).</remarks>
  //  public void Traverse(Action<Type> traversalAction)
  //  {
  //    ReaderLock();
  //    for (int i = 0; i < _count; i++) traversalAction(_list[i]);
  //    ReaderUnlock();
  //  }

  //  /// <summary>Traverses the structure and performs a function on each entry.</summary>
  //  /// <param name="traversalAction">The action within a foreach loop.</param>
  //  /// <param name="start">The index to start the traversal from.</param>
  //  /// <param name="end">The index to end the traversal at.</param>
  //  /// <remarks>Runtime: O((end - start) * traversalAction).</remarks>
  //  public void Traverse(Action<Type> traversalAction, int start, int end)
  //  {
  //    if (start < 0 || start < end || end > _count)
  //      throw new ListArrayException("invalid index parameters on traversal");
  //    ReaderLock();
  //    for (int i = start; i < end; i++) traversalAction(_list[i]);
  //    ReaderUnlock();
  //  }

  //  /// <summary>Converts the list array into a standard array.</summary>
  //  /// <returns>A standard array of all the elements.</returns>
  //  public Type[] ToArray()
  //  {
  //    ReaderLock();
  //    Type[] array = new Type[_count];
  //    for (int i = 0; i < _count; i++) array[i] = _list[i];
  //    ReaderUnlock();
  //    return array;
  //  }

  //  /// <summary>Thread safe enterance for readers.</summary>
  //  protected void ReaderLock() { } //lock (_lock) { while (!(_writers == 0)) Monitor.Wait(_lock); _readers++; } }
  //  /// <summary>Thread safe exit for readers.</summary>
  //  protected void ReaderUnlock() { } //lock (_lock) { _readers--; Monitor.Pulse(_lock); } }
  //  /// <summary>Thread safe enterance for writers.</summary>
  //  protected void WriterLock() { } //lock (_lock) { while (!(_writers == 0) && !(_readers == 0)) Monitor.Wait(_lock); _writers++; } }
  //  /// <summary>Thread safe exit for readers.</summary>
  //  protected void WriterUnlock() { } //lock (_lock) { _writers--; Monitor.PulseAll(_lock); } }

  //  /// <summary>This is used for throwing AVL Tree exceptions only to make debugging faster.</summary>
  //  protected class ListArrayException : Exception { public ListArrayException(string message) : base(message) { } }
  //}

  #endregion
}