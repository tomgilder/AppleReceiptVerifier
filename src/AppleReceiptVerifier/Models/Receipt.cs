﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace AppleReceiptVerifier.Models
{
    /// <summary>
    /// Receipt object
    /// </summary>
    public class Receipt
    {
        /// <summary>
        /// Gets or sets the unique identifier.
        /// </summary>
        /// <value>
        /// The unique identifier.
        /// </value>
        [JsonProperty("unique_identifier")]
        public string UniqueIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the unique vendor identifier.
        /// </summary>
        /// <value>
        /// The unique vendor identifier.
        /// </value>
        [JsonProperty("unique_vendor_identifier")]
        public string UniqueVendorIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the item id.
        /// </summary>
        /// <value>
        /// The item id.
        /// </value>
        [JsonProperty("item_id")]
        public string ItemId { get; set; }

        /// <summary>
        /// Gets or sets the quantity.
        /// </summary>
        /// <value>
        /// The quantity.
        /// </value>
        [JsonProperty("quantity")]
        public int Quantity { get; set; }

        /// <summary>
        /// Gets or sets the product id.
        /// </summary>
        /// <value>
        /// The product id.
        /// </value>
        [JsonProperty("product_id")]
        public string ProductId { get; set; }

        /// <summary>
        /// Gets or sets the transaction id.
        /// </summary>
        /// <value>
        /// The transaction id.
        /// </value>
        [JsonProperty("transaction_id")]
        public string TransactionId { get; set; }

        /// <summary>
        /// Gets or sets the original transaction id.
        /// </summary>
        /// <value>
        /// The original transaction id.
        /// </value>
        [JsonProperty("original_transaction_id")]
        public string OriginalTransactionId { get; set; }

        /// <summary>
        /// Gets or sets the app item id.
        /// </summary>
        /// <value>
        /// The app item id.
        /// </value>
        [JsonProperty("app_item_id")]
        public string AppItemId { get; set; }

        /// <summary>
        /// Gets or sets the version external identifier.
        /// </summary>
        /// <value>
        /// The version external identifier.
        /// </value>
        [JsonProperty("version_external_identifier")]
        public string VersionExternalIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the bundle identifier.
        /// </summary>
        /// <value>
        /// The bundle identifier.
        /// </value>
        [JsonProperty("bid")]
        public string BundleIdentifier { get; set; }

        /// <summary>
        /// Gets or sets the application version number.
        /// </summary>
        /// <value>
        /// The application version number.
        /// </value>
        [JsonProperty("bvrs")]
        public string ApplicationVersionNumber { get; set; }

        /// <summary>
        /// Gets or sets the purchase date UTC.
        /// </summary>
        /// <value>
        /// The purchase date UTC.
        /// </value>
        [JsonProperty("purchase_date")]
        [JsonConverter(typeof(AppleDateTimeConverter))]
        public DateTime PurchaseDateUtc { get; set; }

        /// <summary>
        /// Gets or sets the purchase date PST.
        /// </summary>
        /// <value>
        /// The purchase date PST.
        /// </value>
        [JsonProperty("purchase_date_pst")]
        [JsonConverter(typeof(AppleDateTimeConverter))]
        public DateTime PurchaseDatePst { get; set; }

        /// <summary>
        /// Gets or sets the purchase date in milliseconds.
        /// </summary>
        /// <value>
        /// The purchase date in milliseconds.
        /// </value>
        [JsonProperty("purchase_date_ms")]
        public long PurchaseDateMilliseconds { get; set; }

        /// <summary>
        /// Gets or sets the original purchase date UTC.
        /// </summary>
        /// <value>
        /// The original purchase date UTC.
        /// </value>
        [JsonProperty("original_purchase_date")]
        [JsonConverter(typeof(AppleDateTimeConverter))]
        public DateTime OriginalPurchaseDateUtc { get; set; }

        /// <summary>
        /// Gets or sets the original purchase date PST.
        /// </summary>
        /// <value>
        /// The original purchase date PST.
        /// </value>
        [JsonProperty("original_purchase_date_pst")]
        [JsonConverter(typeof(AppleDateTimeConverter))]
        public DateTime OriginalPurchaseDatePst { get; set; }

        /// <summary>
        /// Gets or sets the original purchase date in milliseconds.
        /// </summary>
        /// <value>
        /// The original purchase date in milliseconds.
        /// </value>
        [JsonProperty("original_purchase_date_ms")]
        public long OriginalPurchaseDateMilliseconds { get; set; }
    }
}
