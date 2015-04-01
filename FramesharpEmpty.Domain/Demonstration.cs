using System;
using Framesharp.Domain;

namespace FramesharpEmpty.Domain
{
    public class Demonstration : IDomainObject
    {
        public virtual int DemonstrationId { get; set; }

        public virtual string SomeDescription { get; set; }

        public virtual int SomeNumber { get; set; }

        public virtual bool SomeFlag { get; set; }

        public virtual DateTime CreationDate { get; set; }

        public virtual DateTime? EditionDate { get; set; }

        /// <summary>
        /// Class constructor
        /// </summary>
        public Demonstration()
        {
            InitializeObject();
        }

        /// <summary>
        /// Initilizes class properties with default values
        /// </summary>
        private void InitializeObject()
        {
            // Virtual properties initilization instructions
        }
        
        /// <summary>
        /// Overrides equality comparison between business domain objects
        ///  so that business information is used instead of comparing 
        ///  object instances
        /// </summary>
        /// <param name="obj">Instance of the object to compare</param>
        /// <returns>True if it is the same object business-wise</returns>
        public override bool Equals(object obj)
        {
            return (obj as Demonstration) != null && this.DemonstrationId == (obj as Demonstration).DemonstrationId;
        }

        /// <summary>
        /// Gets the hash code using business identification values
        /// </summary>
        /// <returns>A hash code that represents this instance</returns>
        public override int GetHashCode()
        {
            return string.Concat(DemonstrationId).GetHashCode();
        }
    }
}