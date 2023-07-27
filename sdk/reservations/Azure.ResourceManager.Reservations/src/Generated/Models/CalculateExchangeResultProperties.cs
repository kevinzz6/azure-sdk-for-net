// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

// <auto-generated/>

#nullable disable

using System;
using System.Collections.Generic;
using Azure.Core;

namespace Azure.ResourceManager.Reservations.Models
{
    /// <summary> CalculateExchange response properties. </summary>
    public partial class CalculateExchangeResultProperties
    {
        /// <summary> Initializes a new instance of CalculateExchangeResultProperties. </summary>
        internal CalculateExchangeResultProperties()
        {
            ReservationsToPurchase = new ChangeTrackingList<ReservationToPurchaseCalculateExchange>();
            SavingsPlansToPurchase = new ChangeTrackingList<SavingsPlanToPurchaseCalculateExchange>();
            ReservationsToExchange = new ChangeTrackingList<ReservationToExchange>();
        }

        /// <summary> Initializes a new instance of CalculateExchangeResultProperties. </summary>
        /// <param name="sessionId"> Exchange session identifier. </param>
        /// <param name="netPayable"> Pricing information containing the amount and the currency code. </param>
        /// <param name="refundsTotal"> Pricing information containing the amount and the currency code. </param>
        /// <param name="purchasesTotal"> Pricing information containing the amount and the currency code. </param>
        /// <param name="reservationsToPurchase"> Details of the reservations being purchased. </param>
        /// <param name="savingsPlansToPurchase"> Details of the savings plans being purchased. </param>
        /// <param name="reservationsToExchange"> Details of the reservations being returned. </param>
        /// <param name="policyResult"> Exchange policy errors. </param>
        internal CalculateExchangeResultProperties(Guid? sessionId, PurchasePrice netPayable, PurchasePrice refundsTotal, PurchasePrice purchasesTotal, IReadOnlyList<ReservationToPurchaseCalculateExchange> reservationsToPurchase, IReadOnlyList<SavingsPlanToPurchaseCalculateExchange> savingsPlansToPurchase, IReadOnlyList<ReservationToExchange> reservationsToExchange, ExchangePolicyErrors policyResult)
        {
            SessionId = sessionId;
            NetPayable = netPayable;
            RefundsTotal = refundsTotal;
            PurchasesTotal = purchasesTotal;
            ReservationsToPurchase = reservationsToPurchase;
            SavingsPlansToPurchase = savingsPlansToPurchase;
            ReservationsToExchange = reservationsToExchange;
            PolicyResult = policyResult;
        }

        /// <summary> Exchange session identifier. </summary>
        public Guid? SessionId { get; }
        /// <summary> Pricing information containing the amount and the currency code. </summary>
        public PurchasePrice NetPayable { get; }
        /// <summary> Pricing information containing the amount and the currency code. </summary>
        public PurchasePrice RefundsTotal { get; }
        /// <summary> Pricing information containing the amount and the currency code. </summary>
        public PurchasePrice PurchasesTotal { get; }
        /// <summary> Details of the reservations being purchased. </summary>
        public IReadOnlyList<ReservationToPurchaseCalculateExchange> ReservationsToPurchase { get; }
        /// <summary> Details of the savings plans being purchased. </summary>
        public IReadOnlyList<SavingsPlanToPurchaseCalculateExchange> SavingsPlansToPurchase { get; }
        /// <summary> Details of the reservations being returned. </summary>
        public IReadOnlyList<ReservationToExchange> ReservationsToExchange { get; }
        /// <summary> Exchange policy errors. </summary>
        internal ExchangePolicyErrors PolicyResult { get; }
        /// <summary> Exchange Policy errors. </summary>
        public IReadOnlyList<ExchangePolicyError> PolicyErrors
        {
            get => PolicyResult?.PolicyErrors;
        }
    }
}
