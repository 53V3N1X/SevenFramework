﻿// Seven
// https://github.com/53V3N1X/SevenFramework
// LISCENSE: See "LISCENSE.md" in th root project directory.
// SUPPORT: See "SUPPORT.md" in the root project directory.

namespace Seven.Algorithms
{
	/// <summary>Contains static sorting algorithms.</summary>
	public static class Sort<T>
	{
		#region Bubble

		/// <summary>Sorts an entire array in non-decreasing order using the bubble sort algorithm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="array">the array to be sorted</param>
		/// <remarks>Runtime: Omega(n), average(n^2), O(n^2). Memory: in place. Stability: yes.</remarks>
		public static void Bubble(T[] array)
		{
			Sort<T>.Bubble(Compare.Default, array, 0, array.Length);
		}

		/// <summary>Sorts an entire array in non-decreasing order using the bubble sort algorithm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="compare">The compare function (returns a positive value if left is greater than right).</param>
		/// <param name="array">the array to be sorted</param>
		/// <remarks>Runtime: Omega(n), average(n^2), O(n^2). Memory: in place. Stability: yes.</remarks>
		public static void Bubble(Compare<T> compare, T[] array)
		{
			Sort<T>.Bubble(compare, array, 0, array.Length);
		}

		/// <summary>Sorts an entire array in non-decreasing order using the bubble sort algorithm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="compare">The compare function (returns a positive value if left is greater than right).</param>
		/// <param name="array">the array to be sorted</param>
		/// <param name="start">The starting index of the sort.</param>
		/// <param name="end">The ending index of the sort.</param>
		/// <remarks>Runtime: Omega(n), average(n^2), O(n^2). Memory: in place. Stability: yes.</remarks>
		public static void Bubble(Compare<T> compare, T[] array, int start, int end)
		{
			Get<T> get = (int index) => { return array[index]; };
			Assign<T> set = (int index, T value) => { array[index] = value; };
			Sort<T>.Bubble(compare, get, set, start, end);
		}

		/// <summary>Sorts an entire array in non-decreasing order using the bubble sort algorithm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="compare">The compare function (returns a positive value if left is greater than right).</param>
		/// <param name="get">Delegate for getting a value at a specified index.</param>
		/// <param name="set">Delegate for setting a value at a specified index.</param>
		/// <param name="start">The starting index of the sort.</param>
		/// <param name="end">The ending index of the sort.</param>
		/// <remarks>Runtime: Omega(n), average(n^2), O(n^2). Memory: in place. Stability: yes.</remarks>
		public static void Bubble(Compare<T> compare, Get<T> get, Assign<T> set, int start, int end)
		{
			for (int i = start; i < end; i++)
				for (int j = start; j < end - 1; j++)
				{
					if (compare(get(j), get(j + 1)) == Comparison.Greater)
					{
						T temp = get(j + 1);
						set(j + 1, get(j));
						set(j, temp);
					}
				}
		}

		#endregion

		#region Selection

		/// <summary>Sorts an entire array in non-decreasing order using the selection sort algoritm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="array">the array to be sorted</param>
		/// <remarks>Runtime: Omega(n^2), average(n^2), O(n^2). Memory: in place. Stablity: no.</remarks>
		public static void Selection(T[] array)
		{
			Sort<T>.Selection(Compare.Default, array, 0, array.Length);
		}

		/// <summary>Sorts an entire array in non-decreasing order using the selection sort algoritm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="compare">Returns negative if the left is less than the right.</param>
		/// <param name="array">the array to be sorted</param>
		/// <remarks>Runtime: Omega(n^2), average(n^2), O(n^2). Memory: in place. Stablity: no.</remarks>
		public static void Selection(Compare<T> compare, T[] array)
		{
			Sort<T>.Selection(compare, array, 0, array.Length);
		}

		/// <summary>Sorts an entire array in non-decreasing order using the selection sort algoritm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="compare">Returns negative if the left is less than the right.</param>
		/// <param name="array">the array to be sorted</param>
		/// <param name="start">The starting index of the sort.</param>
		/// <param name="end">The ending index of the sort.</param>
		/// <remarks>Runtime: Omega(n^2), average(n^2), O(n^2). Memory: in place. Stablity: no.</remarks>
		public static void Selection(Compare<T> compare, T[] array, int start, int end)
		{
			Get<T> get = (int index) => { return array[index]; };
			Assign<T> set = (int index, T value) => { array[index] = value; };
			Sort<T>.Selection(compare, get, set, 0, array.Length);
		}

		/// <summary>Sorts an entire array in non-decreasing order using the selection sort algoritm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="compare">Returns negative if the left is less than the right.</param>
		/// <param name="get">Delegate for getting a value at a specified index.</param>
		/// <param name="set">Delegate for setting a value at a specified index.</param>
		/// <param name="start">The starting index of the sort.</param>
		/// <param name="end">The ending index of the sort.</param>
		/// <remarks>Runtime: Omega(n^2), average(n^2), O(n^2). Memory: in place. Stablity: no.</remarks>
		public static void Selection(Compare<T> compare, Get<T> get, Assign<T> set, int start, int end)
		{
			for (int i = start; i < end; i++)
			{
				int min = i;
				for (int j = i + 1; j < end; j++)
					if (compare(get(j), get(min)) == Comparison.Less)
					{
						min = j;
						T temp = get(i);
						set(i, get(min));
						set(min, temp);
					}
			}
		}

		#endregion

		#region Insertion

		/// <summary>Sorts an entire array in non-decreasing order using the insertion sort algorithm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="array">the array to be sorted</param>
		/// <remarks>Runtime: Omega(n), average(n^2), O(n^2). Memory: in place. Stablity: yes.</remarks>
		public static void Insertion(T[] array)
		{
			Sort<T>.Insertion(Compare.Default, array, 0, array.Length);
		}

		/// <summary>Sorts an entire array in non-decreasing order using the insertion sort algorithm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="compare">Returns positive if left greater than right.</param>
		/// <param name="array">the array to be sorted</param>
		/// <remarks>Runtime: Omega(n), average(n^2), O(n^2). Memory: in place. Stablity: yes.</remarks>
		public static void Insertion(Compare<T> compare, T[] array)
		{
			Sort<T>.Insertion(compare, array, 0, array.Length);
		}

		/// <summary>Sorts an entire array in non-decreasing order using the insertion sort algorithm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="compare">Returns positive if left greater than right.</param>
		/// <param name="array">the array to be sorted</param>
		/// <param name="start">The starting index of the sort.</param>
		/// <param name="end">The ending index of the sort.</param>
		/// <remarks>Runtime: Omega(n), average(n^2), O(n^2). Memory: in place. Stablity: yes.</remarks>
		public static void Insertion(Compare<T> compare, T[] array, int start, int end)
		{
			Get<T> get = (int index) => { return array[index]; };
			Assign<T> set = (int index, T value) => { array[index] = value; };
			Sort<T>.Insertion(compare, get, set, 0, array.Length);
		}

		/// <summary>Sorts an entire array in non-decreasing order using the insertion sort algorithm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="compare">Returns positive if left greater than right.</param>
		/// <param name="get">Delegate for getting a value at a specified index.</param>
		/// <param name="set">Delegate for setting a value at a specified index.</param>
		/// <param name="start">The starting index of the sort.</param>
		/// <param name="end">The ending index of the sort.</param>
		/// <remarks>Runtime: Omega(n), average(n^2), O(n^2). Memory: in place. Stablity: yes.</remarks>
		public static void Insertion(Compare<T> compare, Get<T> get, Assign<T> set, int start, int end)
		{
			for (int i = start + 1; i < end; i++)
			{
				T temp = get(i);
				int j;
				for (j = i; j > start && compare(get(j - 1), temp) == Comparison.Greater; j--)
					set(j, get(j - 1));
				set(j, temp);
			}
		}

		#endregion

		#region Quick

		/// <summary>Sorts an entire array in non-decreasing order using the quick sort algorithm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="array">The array to be sorted</param>
		/// <remarks>Runtime: Omega(n*ln(n)), average(n*ln(n)), O(n^2). Memory: ln(n). Stablity: no.</remarks>
		public static void Quick(T[] array)
		{
			Sort<T>.Quick(Compare.Default, array, 0, array.Length);
		}

		/// <summary>Sorts an entire array in non-decreasing order using the quick sort algorithm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="compare">The method of compare to be sorted by.</param>
		/// <param name="array">The array to be sorted</param>
		/// <remarks>Runtime: Omega(n*ln(n)), average(n*ln(n)), O(n^2). Memory: ln(n). Stablity: no.</remarks>
		public static void Quick(Compare<T> compare, T[] array)
		{
			Sort<T>.Quick(compare, array, 0, array.Length);
		}

		/// <summary>Sorts an entire array in non-decreasing order using the quick sort algorithm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="compare">The method of compare to be sorted by.</param>
		/// <param name="array">The array to be sorted</param>
		/// <param name="start">The starting index of the sort.</param>
		/// <param name="end">The ending index of the sort.</param>
		/// <remarks>Runtime: Omega(n*ln(n)), average(n*ln(n)), O(n^2). Memory: ln(n). Stablity: no.</remarks>
		public static void Quick(Compare<T> compare, T[] array, int start, int end)
		{
			Get<T> get = (int index) => { return array[index]; };
			Assign<T> set = (int index, T value) => { array[index] = value; };
			Sort<T>.Quick(compare, Accessor.Get(array), Accessor.Assign(array), start, end - start);
		}

		/// <summary>Sorts an entire array in non-decreasing order using the quick sort algorithm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="compare">The method of compare to be sorted by.</param>
		/// <param name="get">Delegate for getting a value at a specified index.</param>
		/// <param name="set">Delegate for setting a value at a specified index.</param>
		/// <param name="start">The starting index of the sort.</param>
		/// <param name="end">The ending index of the sort.</param>
		/// <remarks>Runtime: Omega(n*ln(n)), average(n*ln(n)), O(n^2). Memory: ln(n). Stablity: no.</remarks>
		public static void Quick(Compare<T> compare, Get<T> get, Assign<T> set, int start, int end)
		{
			Sort<T>.Quick_Recursive(compare, get, set, start, end - start);
		}

		private static void Quick_Recursive(Compare<T> compare, Get<T> get, Assign<T> set, int start, int len)
		{
			if (len > 1)
			{
				T pivot = get(start);
				int i = start;
				int j = start + len - 1;
				int k = j;
				while (i <= j)
				{
					if (compare(get(j), pivot) == Comparison.Less)
					{
						T temp = get(i);
						set(i++, get(j));
						set(j, temp);
					}
					else if (compare(get(j), pivot) == Comparison.Equal)
						j--;
					else
					{
						T temp = get(k);
						set(k--, get(j));
						set(j--, temp);
					}
				}
				Sort<T>.Quick_Recursive(compare, get, set, start, i - start);
				Sort<T>.Quick_Recursive(compare, get, set, k + 1, start + len - (k + 1));
			}
		}

		#endregion

		#region Merge

		/// <summary>Sorts up to an array in non-decreasing order using the merge sort algorithm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="compare">Returns zero or negative if the left is less than or equal to the right.</param>
		/// <param name="array">The array to be sorted</param>
		/// <remarks>Runtime: Omega(n*ln(n)), average(n*ln(n)), O(n*ln(n)). Memory: n. Stablity: yes.</remarks>
		public static void Merge(T[] array)
		{
			Sort<T>.Merge(Compare.Default, array, 0, array.Length);
		}

		/// <summary>Sorts up to an array in non-decreasing order using the merge sort algorithm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="compare">Returns zero or negative if the left is less than or equal to the right.</param>
		/// <param name="array">The array to be sorted</param>
		/// <remarks>Runtime: Omega(n*ln(n)), average(n*ln(n)), O(n*ln(n)). Memory: n. Stablity: yes.</remarks>
		public static void Merge(Compare<T> compare, T[] array)
		{
			Sort<T>.Merge(compare, array, 0, array.Length);
		}

		/// <summary>Sorts up to an array in non-decreasing order using the merge sort algorithm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="compare">Returns zero or negative if the left is less than or equal to the right.</param>
		/// <param name="array">The array to be sorted</param>
		/// <param name="start">The starting index of the sort.</param>
		/// <param name="end">The ending index of the sort.</param>
		/// <remarks>Runtime: Omega(n*ln(n)), average(n*ln(n)), O(n*ln(n)). Memory: n. Stablity: yes.</remarks>
		public static void Merge(Compare<T> compare, T[] array, int start, int end)
		{
			Get<T> get = (int index) => { return array[index]; };
			Assign<T> set = (int index, T value) => { array[index] = value; };
			Sort<T>.Merge(compare, get, set, start, end - start);
		}

		/// <summary>Sorts up to an array in non-decreasing order using the merge sort algorithm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="compare">Returns zero or negative if the left is less than or equal to the right.</param>
		/// <param name="get">Delegate for getting a value at a specified index.</param>
		/// <param name="set">Delegate for setting a value at a specified index.</param>
		/// <param name="start">The starting index of the sort.</param>
		/// <param name="end">The ending index of the sort.</param>
		/// <remarks>Runtime: Omega(n*ln(n)), average(n*ln(n)), O(n*ln(n)). Memory: n. Stablity: yes.</remarks>
		public static void Merge(Compare<T> compare, Get<T> get, Assign<T> set, int start, int end)
		{
			Sort<T>.Merge_Recursive(compare, get, set, start, end - start);
		}

		private static void Merge_Recursive(Compare<T> compare, Get<T> get, Assign<T> set, int start, int len)
		{
			if (len > 1)
			{
				int half = len / 2;
				Sort<T>.Merge_Recursive(compare, get, set, start, half);
				Sort<T>.Merge_Recursive(compare, get, set, start + half, len - half);
				T[] sorted = new T[len];
				int i = start;
				int j = start + half;
				int k = 0;
				while (i < start + half && j < start + len)
				{
					if (compare(get(i), get(j)) == Comparison.Greater)
						sorted[k++] = get(j++);
					else
						sorted[k++] = get(i++);
				}
				for (int h = 0; h < start + half - i; h++)
					sorted[k + h] = get(i + h);
				for (int h = 0; h < start + len - j; h++)
					sorted[k + h] = get(j + h);
				for (int h = 0; h < len; h++)
					set(start + h, sorted[0 + h]);
			}
		}

		#endregion

		#region Heap

		/// <summary>Sorts an entire array in non-decreasing order using the heap sort algorithm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="array">The array to be sorted</param>
		/// <remarks>Runtime: Omega(n*ln(n)), average(n*ln(n)), O(n^2). Memory: in place. Stablity: no.</remarks>
		public static void Heap(T[] array)
		{
			Sort<T>.Heap(Compare.Default, array, 0, array.Length);
		}

		/// <summary>Sorts an entire array in non-decreasing order using the heap sort algorithm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="compare">The method of compare for the sort.</param>
		/// <param name="array">The array to be sorted</param>
		/// <remarks>Runtime: Omega(n*ln(n)), average(n*ln(n)), O(n^2). Memory: in place. Stablity: no.</remarks>
		public static void Heap(Compare<T> compare, T[] array)
		{
			Sort<T>.Heap(compare, array, 0, array.Length);
		}

		/// <summary>Sorts an entire array in non-decreasing order using the heap sort algorithm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="compare">The method of compare for the sort.</param>
		/// <param name="array">The array to be sorted</param>
		/// <param name="start">The starting index of the sort.</param>
		/// <param name="end">The ending index of the sort.</param>
		/// <remarks>Runtime: Omega(n*ln(n)), average(n*ln(n)), O(n^2). Memory: in place. Stablity: no.</remarks>
		public static void Heap(Compare<T> compare, T[] array, int start, int end)
		{
			Get<T> get = (int index) => { return array[index]; };
			Assign<T> set = (int index, T value) => { array[index] = value; };
			Sort<T>.Heap(compare, get, set, start, end);
		}

		/// <summary>Sorts an entire array in non-decreasing order using the heap sort algorithm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="compare">The method of compare for the sort.</param>
		/// <param name="get">Delegate for getting a value at a specified index.</param>
		/// <param name="set">Delegate for setting a value at a specified index.</param>
		/// <param name="start">The starting index of the sort.</param>
		/// <param name="end">The ending index of the sort.</param>
		/// <remarks>Runtime: Omega(n*ln(n)), average(n*ln(n)), O(n^2). Memory: in place. Stablity: no.</remarks>
		public static void Heap(Compare<T> compare, Get<T> get, Assign<T> set, int start, int end)
		{
			int heapSize = end - start;
			for (int i = (heapSize - 1) / 2; i >= 0; i--)
				Sort<T>.MaxHeapify(compare, get, set, heapSize, i);
			for (int i = end - 1; i > start; i--)
			{
				T temp = get(0);
				set(0, get(i));
				set(i, temp);
				heapSize--;
				Sort<T>.MaxHeapify(compare, get, set, heapSize, 0);
			}
		}

		private static void MaxHeapify(Compare<T> compare, Get<T> get, Assign<T> set, int heapSize, int index)
		{
			int left = (index + 1) * 2 - 1;
			int right = (index + 1) * 2;
			int largest = 0;
			if (left < heapSize && compare(get(left), get(index)) == Comparison.Greater)
				largest = left;
			else
				largest = index;
			if (right < heapSize && compare(get(right), get(largest)) == Comparison.Greater)
				largest = right;
			if (largest != index)
			{
				T temp = get(index);
				set(index, get(largest));
				set(largest, temp);
				Sort<T>.MaxHeapify(compare, get, set, heapSize, largest);
			}
		}

		#endregion

		#region OddEven

		/// <summary>Sorts an entire array in non-decreasing order using the odd-even sort algorithm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="array">The array to be sorted</param>
		/// <remarks>Runtime: Omega(n), average(n^2), O(n^2). Memory: in place. Stablity: yes.</remarks>
		public static void OddEven(T[] array)
		{
			Sort<T>.OddEven(Compare.Default, array, 0, array.Length);
		}

		/// <summary>Sorts an entire array in non-decreasing order using the odd-even sort algorithm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="compare">The method of compare for the sort.</param>
		/// <param name="array">The array to be sorted</param>
		/// <remarks>Runtime: Omega(n), average(n^2), O(n^2). Memory: in place. Stablity: yes.</remarks>
		public static void OddEven(Compare<T> compare, T[] array)
		{
			Sort<T>.OddEven(compare, array, 0, array.Length);
		}

		/// <summary>Sorts an entire array in non-decreasing order using the odd-even sort algorithm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="compare">The method of compare for the sort.</param>
		/// <param name="array">The array to be sorted</param>
		/// <remarks>Runtime: Omega(n), average(n^2), O(n^2). Memory: in place. Stablity: yes.</remarks>
		public static void OddEven(Compare<T> compare, T[] array, int start, int end)
		{
			Get<T> get = (int index) => { return array[index]; };
			Assign<T> set = (int index, T value) => { array[index] = value; };
			Sort<T>.OddEven(compare, get, set, start, end);
		}

		/// <summary>Sorts an entire array in non-decreasing order using the odd-even sort algorithm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="compare">The method of compare for the sort.</param>
		/// <param name="get">Delegate for getting a value at a specified index.</param>
		/// <param name="set">Delegate for setting a value at a specified index.</param>
		/// <remarks>Runtime: Omega(n), average(n^2), O(n^2). Memory: in place. Stablity: yes.</remarks>
		public static void OddEven(Compare<T> compare, Get<T> get, Assign<T> set, int start, int end)
		{
			var sorted = false;
			while (!sorted)
			{
				sorted = true;
				for (var i = start + 1; i < end - 1; i += 2)
				{
					if (compare(get(i), get(i + 1)) == Comparison.Greater)
					{
						T temp = get(i);
						set(i, get(i + 1));
						set(i + 1, temp);
						sorted = false;
					}
				}
				for (var i = start; i < end - 1; i += 2)
				{
					if (compare(get(i), get(i + 1)) == Comparison.Greater)
					{
						T temp = get(i);
						set(i, get(i + 1));
						set(i + 1, temp);
						sorted = false;
					}
				}
			}
		}

		#endregion

		#region Counting (In Development)

		///// <summary>Method specifically for computing object keys in the Counting Sort algorithm.</summary>
		///// <typeparam name="T">The type of instances in the array to be sorted.</typeparam>
		///// <param name="instance">The instance to compute a counting key for.</param>
		///// <returns>The counting key computed from the provided instance.</returns>
		//public delegate int ComputeCountingKey(T instance);

		///// <summary>Sorts an entire array in non-decreasing order using the heap sort algorithm.</summary>
		///// <typeparam name="T">The type of objects stored within the array.</typeparam>
		///// <param name="computeCountingKey">Method specifically for computing object keys in the Counting Sort algorithm.</param>
		///// <param name="array">The array to be sorted</param>
		///// <remarks>Runtime: Theta(Max(key)). Memory: Max(key). Stablity: yes.</remarks>
		//public static void Counting(ComputeCountingKey computeCountingKey, T[] array)
		//{
		//	throw new System.NotImplementedException();

		//	// This code needs revision and conversion
		//	int[] count = new int[array.Length];
		//	int maxKey = 0;
		//	for (int i = 0; i < array.Length; i++)
		//	{
		//		int key = computeCountingKey(array[i]) / array.Length;
		//		count[key] += 1;
		//		if (key > maxKey)
		//			maxKey = key;
		//	}

		//	int total = 0;
		//	for (int i = 0; i < maxKey; i++)
		//	{
		//		int oldCount = count[i];
		//		count[i] = total;
		//		total += oldCount;
		//	}

		//	T[] output = new T[maxKey];
		//	for (int i = 0; i < array.Length; i++)
		//	{
		//		int key = computeCountingKey(array[i]);
		//		output[count[key]] = array[i];
		//		count[computeCountingKey(array[i])] += 1;
		//	}
		//}

		///// <summary>Sorts an entire array in non-decreasing order using the heap sort algorithm.</summary>
		///// <typeparam name="T">The type of objects stored within the array.</typeparam>
		///// <param name="computeCountingKey">Method specifically for computing object keys in the Counting Sort algorithm.</param>
		///// <param name="array">The array to be sorted</param>
		///// <remarks>Runtime: Theta(Max(key)). Memory: Max(key). Stablity: yes.</remarks>
		//public static void Counting(ComputeCountingKey computeCountingKey, T[] array, int start, int end)
		//{
		//	throw new System.NotImplementedException();
		//}

		///// <summary>Sorts an entire array in non-decreasing order using the heap sort algorithm.</summary>
		///// <typeparam name="T">The type of objects stored within the array.</typeparam>
		///// <param name="computeCountingKey">Method specifically for computing object keys in the Counting Sort algorithm.</param>
		///// <param name="array">The array to be sorted</param>
		///// <remarks>Runtime: Theta(Max(key)). Memory: Max(key). Stablity: yes.</remarks>
		//public static void Counting(ComputeCountingKey computeCountingKey, Get<T> get, Assign<T> set, int start, int end)
		//{
		//	throw new System.NotImplementedException();
		//}

		#endregion

		#region Shuffle

		/// <summary>Sorts an entire array in a randomized order.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="array">The aray to shuffle.</param>
		/// <remarks>Runtime: O(n). Memory: in place. Stable: N/A (not a comparative sort).</remarks>
		public static void Shuffle(T[] array)
		{
			Sort<T>.Shuffle(array, 0, array.Length);
		}

		/// <summary>Sorts an entire array in a randomized order.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="array">The aray to shuffle.</param>
		/// <remarks>Runtime: O(n). Memory: in place. Stable: N/A (not a comparative sort).</remarks>
		public static void Shuffle(T[] array, int start, int end)
		{
			Get<T> get = (int index) => { return array[index]; };
			Assign<T> set = (int index, T value) => { array[index] = value; };
			Sort<T>.Shuffle(get, set, start, end);
		}

		/// <summary>Sorts an entire array in a randomized order.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="array">The aray to shuffle.</param>
		/// <remarks>Runtime: O(n). Memory: in place. Stable: N/A (not a comparative sort).</remarks>
		public static void Shuffle(Get<T> get, Assign<T> set, int start, int end)
		{
			Shuffle(new System.Random(), get, set, start, end);
		}

		/// <summary>Sorts an entire array in a randomized order.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="array">The aray to shuffle.</param>
		/// <remarks>Runtime: O(n). Memory: in place. Stable: N/A (not a comparative sort).</remarks>
		public static void Shuffle(System.Random random, Get<T> get, Assign<T> set, int start, int end)
		{
			for (int i = start; i < end; i++)
			{
				int randomIndex = random.Next(start, end);
				T temp = get(i);
				set(i, get(randomIndex));
				set(randomIndex, temp);
			}
		}

		#endregion

		#region Bogo

		/// <summary>Sorts an entire array in non-decreasing order using the slow sort algorithm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="array">The array to be sorted.</param>
		/// <remarks>Runtime: Omega(n), average(n*n!), O(infinity). Memory: in place. Stablity: no.</remarks>
		public static void Bogo(T[] array)
		{
			Sort<T>.Bogo(Compare.Default, array, 0, array.Length);
		}

		/// <summary>Sorts an entire array in non-decreasing order using the slow sort algorithm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="compare">The method of compare for the sort.</param>
		/// <param name="array">The array to be sorted.</param>
		/// <remarks>Runtime: Omega(n), average(n*n!), O(infinity). Memory: in place. Stablity: no.</remarks>
		public static void Bogo(Compare<T> compare, T[] array)
		{
			Sort<T>.Bogo(compare, array, 0, array.Length);
		}

		/// <summary>Sorts an entire array in non-decreasing order using the slow sort algorithm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="compare">The method of compare for the sort.</param>
		/// <param name="array">The array to be sorted.</param>
		/// <remarks>Runtime: Omega(n), average(n*n!), O(infinity). Memory: in place. Stablity: no.</remarks>
		public static void Bogo(Compare<T> compare, T[] array, int start, int end)
		{
			Get<T> get = (int index) => { return array[index]; };
			Assign<T> set = (int index, T value) => { array[index] = value; };
			Sort<T>.Bogo(compare, get, set, start, end);
		}

		/// <summary>Sorts an entire array in non-decreasing order using the slow sort algorithm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="compare">The method of compare for the sort.</param>
		/// <param name="array">The array to be sorted.</param>
		/// <remarks>Runtime: Omega(n), average(n*n!), O(infinity). Memory: in place. Stablity: no.</remarks>
		public static void Bogo(Compare<T> compare, Get<T> get, Assign<T> set, int start, int end)
		{
			while (!BogoCheck(compare, get, set, start, end))
				Sort<T>.Shuffle(get, set, start, end);
		}

		private static bool BogoCheck(Compare<T> compare, Get<T> get, Assign<T> set, int start, int end)
		{
			for (int i = start; i < end - 1; i++)
				if (compare(get(i), get(i + 1)) == Comparison.Greater)
					return false;
			return true;
		}

		#endregion

		#region Slow

		/// <summary>Sorts an entire array of in non-decreasing order using the slow sort algorithm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="array">The array to be sorted</param>
		/// <remarks>Runtime: Omega(n), average(n*n!), O(n*n!). Memory: in place. Stablity: N/A (not yet analyzed).</remarks>
		public static void Slow(T[] array)
		{
			Sort<T>.Slow(Compare.Default, array, 0, array.Length);
		}

		/// <summary>Sorts an entire array of in non-decreasing order using the slow sort algorithm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="compare">The method of compare for the sort.</param>
		/// <param name="array">The array to be sorted</param>
		/// <remarks>Runtime: Omega(n), average(n*n!), O(n*n!). Memory: in place. Stablity: N/A (not yet analyzed).</remarks>
		public static void Slow(Compare<T> compare, T[] array)
		{
			Sort<T>.Slow(compare, array, 0, array.Length);
		}

		/// <summary>Sorts an entire array of in non-decreasing order using the slow sort algorithm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="compare">The method of compare for the sort.</param>
		/// <param name="array">The array to be sorted</param>
		/// <remarks>Runtime: Omega(n), average(n*n!), O(n*n!). Memory: in place. Stablity: N/A (not yet analyzed).</remarks>
		public static void Slow(Compare<T> compare, T[] array, int start, int end)
		{
			Get<T> get = (int index) => { return array[index]; };
			Assign<T> set = (int index, T value) => { array[index] = value; };
			Sort<T>.Slow(compare, get, set, start, end);
		}

		/// <summary>Sorts an entire array of in non-decreasing order using the slow sort algorithm.</summary>
		/// <typeparam name="T">The type of objects stored within the array.</typeparam>
		/// <param name="compare">The method of compare for the sort.</param>
		/// <param name="array">The array to be sorted</param>
		/// <remarks>Runtime: Omega(n), average(n*n!), O(n*n!). Memory: in place. Stablity: N/A (not yet analyzed).</remarks>
		public static void Slow(Compare<T> compare, Get<T> get, Assign<T> set, int start, int end)
		{
			throw new System.NotImplementedException();

			Sort<T>.Slow_Recursive(compare, get, set, start, end);
		}

		private static void Slow_Recursive(Compare<T> compare, Get<T> get, Assign<T> set, int i, int j)
		{
			if (i >= j)
				return;
			int m = (i + j) / 2;
			Sort<T>.Slow_Recursive(compare, get, set, i, m);
			Sort<T>.Slow_Recursive(compare, get, set, m + 1, j);
			if (compare(get(m), get(j)) == Comparison.Less)
			{
				T temp = get(j);
				set(j, get(m));
				set(m, temp);
			}
			Sort<T>.Slow_Recursive(compare, get, set, i, j - 1);
		}

		#endregion
	}
}
