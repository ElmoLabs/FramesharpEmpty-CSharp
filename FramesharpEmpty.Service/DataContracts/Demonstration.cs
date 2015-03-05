using System;
using System.Runtime.Serialization;

namespace FramesharpEmpty.Service.DataContracts
{
    [DataContract]
    public class Demonstration
    {
        [DataMember]
        public int DemonstrationId { get; set; }

        [DataMember]
        public string SomeDescription { get; set; }

        [DataMember]
        public int SomeNumber { get; set; }

        [DataMember]
        public bool SomeFlag { get; set; }

        [DataMember]
        public DateTime CreationDate { get; internal set; }

        [DataMember]
        public DateTime EditionDate { get; internal set; }

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
        public void InitializeObject()
        {
            // Virtual properties initilization instructions
        }

        public override bool Equals(object obj)
        {
            return (obj as Demonstration) != null && this.DemonstrationId == (obj as Demonstration).DemonstrationId;
        }

        public override int GetHashCode()
        {
            return string.Concat(DemonstrationId).GetHashCode();
        }
    }
}