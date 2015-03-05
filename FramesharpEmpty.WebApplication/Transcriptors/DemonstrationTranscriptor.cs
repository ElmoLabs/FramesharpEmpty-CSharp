namespace FramesharpEmpty.WebApplication.Transcriptors
{
    public class DemonstrationTranscriptor
    {
        /// <summary>
        /// Converts a domain object into a model instance transfering all information from the source
        ///  object to the resulting instance. Transcription should only be applied to properties
        ///  whose values are not lazy loaded or readonly.
        /// </summary>
        /// <param name="source">An instance of the domain object to be transcripted from</param>
        /// <returns>An instance of a transcripted model</returns>
        public static Models.Demonstration ConvertToModelFromDomain(Domain.Demonstration source)
        {
            return ConvertToModelFromDomain(null, source);
        }

        /// <summary>
        /// Converts a domain object into a model instance transfering all information from the source
        ///  object to the resulting instance. Transcription should only be applied to properties
        ///  whose values are not lazy loaded or readonly.
        /// </summary>
        /// <param name="result">An instance of the model to be transcripted to</param>
        /// <param name="source">An instance of the domain object to be transcripted from</param>
        /// <returns>An instance of a transcripted model</returns>
        public static Models.Demonstration ConvertToModelFromDomain(Models.Demonstration result, Domain.Demonstration source)
        {
            if (source == null)
            {
                return null;
            }

            if (result == null)
            {
                result = new Models.Demonstration();
            }

            result.DemonstrationId  = source.DemonstrationId;
            result.SomeDescription  = source.SomeDescription;
            result.SomeFlag         = source.SomeFlag;
            result.SomeNumber       = source.SomeNumber;
            result.CreationDate     = source.CreationDate;
            result.EditionDate      = source.EditionDate;

            return result;
        }

        /// <summary>
        /// Converts a model into a domain object instance transfering all information from the source
        ///  object to the resulting instance. Transcription should only be applied to properties
        ///  whose values are not lazy loaded or readonly.
        /// </summary>
        /// <param name="source">An instance of the domain object to be transcripted to</param>
        /// <returns>An instance of a transcripted domain object</returns>
        public static Domain.Demonstration ConvertFromModelToDomain(Models.Demonstration source)
        {
            return ConvertFromModelToDomain(source, null);
        }

        /// <summary>
        /// Converts a model into a domain object instance transfering all information from the source
        ///  object to the resulting instance. Transcription should only be applied to properties
        ///  whose values are not lazy loaded or readonly.
        /// </summary>
        /// <param name="result">An instance of the model to be transcripted from</param>
        /// <param name="source">An instance of the domain object to be transcripted to</param>
        /// <returns>An instance of a transcripted domain object</returns>
        public static Domain.Demonstration ConvertFromModelToDomain(Models.Demonstration source, Domain.Demonstration result)
        {
            if (source == null)
            {
                return null;
            }

            if (result == null)
            {
                result = new Domain.Demonstration();
            }

            result.DemonstrationId  = source.DemonstrationId;
            result.SomeDescription  = source.SomeDescription;
            result.SomeFlag         = source.SomeFlag;
            result.SomeNumber       = source.SomeNumber;
            result.CreationDate     = source.CreationDate;
            result.EditionDate      = source.EditionDate;

            return result;
        }
    }
}