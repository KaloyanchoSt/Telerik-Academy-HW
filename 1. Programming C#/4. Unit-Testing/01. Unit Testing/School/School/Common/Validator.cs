namespace School.Common
{
    using System;
    using System.Collections.Generic;

    public class Validator
    {
        public static void ValidateIfInRange(int value, int max, int min, string message)
        {
            if (value > min || value > max)
            {
                throw new ArgumentException(message);
            }
        }

        public static void ValidateIfNull(object value, string message)
        {
            if (value == null)
            {
                throw new ArgumentNullException(message);
            }
        }

        public static void ValidateIfStringIsNullOrEmpty(string text, string message)
        {
            if (string.IsNullOrEmpty(text))
            {
                throw new NullReferenceException(message);
            }
        }

        public static bool IsPartOfCollection<T>(IEnumerable<T> collection, T collectionMember)
        {
            ValidateIfNull(collection, "Collection");
            ValidateIfNull(collectionMember, "CollectionMember");

            foreach (var member in collection)
            {
                if (member.Equals(collectionMember))
                {
                    return true;
                }
            }

            return false;
        }
    }
}