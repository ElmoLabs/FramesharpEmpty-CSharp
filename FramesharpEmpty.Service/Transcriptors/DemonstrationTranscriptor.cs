using System;

namespace FramesharpEmpty.Service.Transcriptors
{
    public static class DemonstrationTranscriptor
    {
        /// <summary>
        /// Converts a domain object into a data contract instance transfering all information from the source
        ///  object to the resulting instance. Transcription should only be applied to properties
        ///  whose values are not lazy loaded or readonly.
        /// </summary>
        /// <param name="source">An instance of the domain object to be transcripted from</param>
        /// <returns>An instance of a transcripted data contract</returns>
        public static DataContracts.Demonstration ConvertToDataContractFromDomain(Domain.Demonstration source)
        {
            return ConvertToDataContractFromDomain(null, source);
        }

        /// <summary>
        /// Converts a domain object into a data contract instance transfering all information from the source
        ///  object to the resulting instance. Transcription should only be applied to properties
        ///  whose values are not lazy loaded or readonly.
        /// </summary>
        /// <param name="result">An instance of the data contract to be transcripted to</param>
        /// <param name="source">An instance of the domain object to be transcripted from</param>
        /// <returns>An instance of a transcripted data contract</returns>
        public static DataContracts.Demonstration ConvertToDataContractFromDomain(DataContracts.Demonstration result, Domain.Demonstration source)
        {
            if (source == null)
            {
                return null;
            }

            if (result == null)
            {
                result = new DataContracts.Demonstration();
            }

            result.DemonstrationId  = source.DemonstrationId;
            result.SomeDescription  = source.SomeDescription;
            result.SomeFlag         = source.SomeFlag;
            result.SomeNumber       = source.SomeNumber;
            result.CreationDate     = source.CreationDate ?? new DateTime();
            result.EditionDate      = source.EditionDate ?? new DateTime();

            return result;
        }

        /// <summary>
        /// Converts a data contract into a domain object instance transfering all information from the source
        ///  object to the resulting instance. Transcription should only be applied to properties
        ///  whose values are not lazy loaded or readonly.
        /// </summary>
        /// <param name="source">An instance of the domain object to be transcripted to</param>
        /// <returns>An instance of a transcripted domain object</returns>
        public static Domain.Demonstration ConvertFromDataContractToDomain(DataContracts.Demonstration source)
        {
            return ConvertFromDataContractToDomain(source, null);
        }

        /// <summary>
        /// Converts a data contract into a domain object instance transfering all information from the source
        ///  object to the resulting instance. Transcription should only be applied to properties
        ///  whose values are not lazy loaded or readonly.
        /// </summary>
        /// <param name="result">An instance of the data contract to be transcripted from</param>
        /// <param name="source">An instance of the domain object to be transcripted to</param>
        /// <returns>An instance of a transcripted domain object</returns>
        public static Domain.Demonstration ConvertFromDataContractToDomain(DataContracts.Demonstration source, Domain.Demonstration result)
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