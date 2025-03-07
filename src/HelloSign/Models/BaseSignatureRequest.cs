﻿using System;
using System.Collections.Generic;

namespace HelloSign
{
    /// <summary>
    /// Base class for Template-based and File-based Signature Request classes.
    /// </summary>
    public class BaseSignatureRequest
    {
        public string SignatureRequestId { get; set; }
        public string Title { get; set; }
        public string Subject { get; set; }
        public string Message { get; set; }
        public bool TestMode { get; set; }
        public Dictionary<String, String> Metadata { get; set; }
        public DateTime CreatedAt { get; set; }
        public bool IsComplete { get; set; }
        public bool HasError { get; set; }
        public List<CustomField> CustomFields { get; set; }
        public List<FieldResponse> ResponseData { get; set; }
        public string SigningUrl { get; set; }
        public string SigningRedirectUrl { get; set; }
        public string RequestingRedirectUrl { get; set; }
        public bool IsForEmbeddedSigning { get; set; }
        public string DetailsUrl { get; set; }
        public string RequesterEmailAddress { get; set; }
        public bool AllowDecline { get; set; }
        public bool SkipMeNow { get; set; }
        public bool HoldRequest { get; set; }
        public List<Signature> Signatures { get; set; }
        public List<string> CcEmailAddresses { get; set; }
        public SigningOptions SigningOptions { get; set; }

        public List<Signer> Signers = new List<Signer>();

        public BaseSignatureRequest()
        {
            Metadata = new Dictionary<String, String>();
            CustomFields = new List<CustomField>();
            CcEmailAddresses = new List<string>();
            AllowDecline = false;
        }

        /// <summary>
        /// Get the Custom Field with a specified name, or null.
        /// </summary>
        /// <param name="name"></param>
        /// <returns></returns>
        public CustomField GetCustomField(string name)
        {
            foreach (var customField in CustomFields)
            {
                if (customField.Name.Equals(name))
                {
                    return customField;
                }
            }
            return null;
        }
    }
}
