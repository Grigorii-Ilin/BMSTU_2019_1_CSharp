using System;
using System.Collections.Generic;
using System.Text;

namespace Set {
    public class MySet {
        public List<int> UniqueValues { get; private set; }
        //private List<int> uniqueValues;

        public MySet(int[] values) {
            foreach (var value in values) {
                if (!UniqueValues.Contains(value)) {
                    UniqueValues.Add(value);
                }
            }
        }

        public MySet() { }

        public int GetCardinality() {
            return UniqueValues.Count;
        }

        public void AddValue(int value) {
            if (!UniqueValues.Contains(value)) {
                UniqueValues.Add(value);
            }
        }

        public void RemoveValue(int value) {
            UniqueValues.Remove(value);
        }

        public static MySet operator + (MySet lhs, MySet rhs) {            
            var result = new MySet();
            result.UniqueValues.AddRange(lhs.UniqueValues);

            foreach (var value in rhs.UniqueValues) {
                if (!result.UniqueValues.Contains(value)) {
                    result.UniqueValues.Add(value);
                }
            }

            return result;
        }

        public static MySet operator -(MySet lhs, MySet rhs) {
            var result = new MySet();
            result.UniqueValues.AddRange(lhs.UniqueValues);

            foreach (var value in rhs.UniqueValues) {
                if (result.UniqueValues.Contains(value)) {
                    result.UniqueValues.Remove(value);
                }
            }

            return result;
        }

        public static MySet operator *(MySet lhs, MySet rhs) {
            var result = new MySet();

            foreach (var lValue in lhs.UniqueValues) {
                foreach (var rValue in rhs.UniqueValues) {
                    if (lValue== rValue) {
                        result.UniqueValues.Add(lValue);
                    }
                }
            }

            return result;
        }

        public static bool operator ==(MySet lhs, MySet rhs) {
            if (lhs.UniqueValues.Count!= rhs.UniqueValues.Count) {
                return false;
            }

            foreach (var lValue in lhs.UniqueValues) {
                foreach (var rValue in rhs.UniqueValues) {
                    if (lValue != rValue) {
                        return false;
                    }
                }
            }

            return true;
        }

        public static bool operator !=(MySet lhs, MySet rhs) {
            return !(lhs == rhs);
        }
    }
}
