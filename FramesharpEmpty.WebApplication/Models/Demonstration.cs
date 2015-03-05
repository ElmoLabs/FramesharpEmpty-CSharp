using System;
using Framesharp.Presentation.Web.Mvc.Models;

namespace FramesharpEmpty.WebApplication.Models
{
    public class Demonstration : ModelBase
    {
        public static implicit operator Domain.Demonstration(Models.Demonstration model)
        {
            return Transcriptors.DemonstrationTranscriptor.ConvertFromModelToDomain(model, new Domain.Demonstration());
        }

        public static implicit operator Models.Demonstration(Domain.Demonstration domain)
        {
            return Transcriptors.DemonstrationTranscriptor.ConvertToModelFromDomain(new Models.Demonstration(), domain);
        }

        public virtual int DemonstrationId { get; set; }

        public virtual string SomeDescription { get; set; }

        public virtual int SomeNumber { get; set; }

        public virtual bool SomeFlag { get; set; }

        public virtual DateTime? CreationDate { get; set; }

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

        public override bool Equals(object obj)
        {
            return (obj as Models.Demonstration) != null && 
                DemonstrationId == (obj as Models.Demonstration).DemonstrationId;
        }

        public override int GetHashCode()
        {
            return string.Concat(DemonstrationId).GetHashCode();
        }
    }
}