using System;
using System.Collections;
using  System.Collections.Generic;
namespace BiHW1
{
    /*
     * I am going to implement a class
     */
    public class BiHwOne
    {
        // Private member variables
        private int X { get; set; }
        private int Y { get; set; }
        private readonly int[] _array;
        private readonly List<int> _arrayList;

        // Default constructor
        public BiHwOne()
        {
        }

        // Construction with parameter or member variable
        public BiHwOne(int y, int x, int arrLength)
        {
            this.Y = y;
            this.X = x;
            this._array = new int[arrLength];

            for (int i = 0; i < arrLength; i++)
                this._array[i] = 0;

            _arrayList = new List<int>();
        }

        // Setter and Getter
        public int GetX()
        {
            return this.X;
        }

        public void SetX(int x)
        {
            this.X = x;
        }

        public int GetY()
        {
            return this.Y;
        }

        public void SetY(int y)
        {
            this.Y = y;
        }

        public void SetArrayList(int n)
        {
            for (int i = 0; i < n; i++)
                this._arrayList.Add(i+1);
        }

        public List<int> GetArrayList()
        {
            return _arrayList;
        }

        // Add Method
        // Adding X and Y
        public int Add()
        {
            return this.X + this.Y;
        }

        // Sum of Array
        // Get Sum of total array
        public int GetSumTotalOfArray()
        {
            int sum = 0;
            for (int i = 0; i < _array.Length; i++)
                sum += _array[i];

            return sum;
        }
        
        // Sum of ArrayList
        // Get Sum of total ArrayList
        public int GetSumOfTotalArrayList()
        {
            int sum = 0;

            for (int i = 0; i < this._arrayList.Count; i++)
            {
                sum += _arrayList[i];
            }

            return sum;
        }
    }
}