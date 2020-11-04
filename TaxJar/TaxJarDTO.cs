using System;
using System.Collections.Generic;
using System.Globalization;
using Newtonsoft.Json;
using Newtonsoft.Json.Converters;

namespace TaxJar
{   
    public partial class TaxJarDTO
    {
        [JsonProperty("rate")]
        public Rate Rate { get; set; }
    }

    public partial class Rate
    {
        [JsonProperty("city")]
        public string City { get; set; }

        [JsonProperty("city_rate")]
        public string CityRate { get; set; }

        [JsonProperty("combined_district_rate")]
        public string CombinedDistrictRate { get; set; }

        [JsonProperty("combined_rate")]
        public string CombinedRate { get; set; }

        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("country_rate")]
        public string CountryRate { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("county_rate")]
        public string CountyRate { get; set; }

        [JsonProperty("freight_taxable")]
        public bool FreightTaxable { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("state_rate")]
        public string StateRate { get; set; }

        [JsonProperty("zip")]
        public string Zip { get; set; }
    }

    public partial class TaxOrder
    {
        [JsonProperty("tax")]
        public Tax Tax { get; set; }
    }

    public partial class PostTaxOrder
    {
        [JsonProperty("transaction_id")]
        public int TransactionId { get; set; }
        [JsonProperty("transaction_date")]
        public DateTime TransactionDate { get; set; }
        [JsonProperty("to_country")]
        public string ToCountry { get; set; }
        [JsonProperty("to_zip")]
        public string ToZip { get; set; }
        [JsonProperty("to_state")]
        public string ToState { get; set; }
        [JsonProperty("to_city")]
        public string ToCity { get; set; }
        [JsonProperty("to_street")]
        public string ToStreet { get; set; }
        [JsonProperty("amount")]
        public double Amount { get; set; }
        [JsonProperty("shipping")]
        public double Shipping { get; set; }
        [JsonProperty("sales_tax")]
        public double SalesTax { get; set; }
        [JsonProperty("line_items")]
        public PostLineItem LineItems { get; set; }
    }

    public partial class PostLineItem
    {
         [JsonProperty("quantity")]
         public int Quantity { get; set; }
        [JsonProperty("product_identifier")]
        public string ProductIdentifier { get; set; }
        [JsonProperty("description")]
        public string Description { get; set; }
        [JsonProperty("unit_price")]
        public double UnitPrice { get; set; }
        [JsonProperty("sales_tax")]
        public double SalesTax { get; set; }
    }

    public partial class Tax
    {
        [JsonProperty("order_total_amount")]
        public double OrderTotalAmount { get; set; }

        [JsonProperty("shipping")]
        public double Shipping { get; set; }

        [JsonProperty("taxable_amount")]
        public long TaxableAmount { get; set; }

        [JsonProperty("amount_to_collect")]
        public double AmountToCollect { get; set; }

        [JsonProperty("rate")]
        public double Rate { get; set; }

        [JsonProperty("has_nexus")]
        public bool HasNexus { get; set; }

        [JsonProperty("freight_taxable")]
        public bool FreightTaxable { get; set; }

        [JsonProperty("tax_source")]
        public string TaxSource { get; set; }

        [JsonProperty("jurisdictions")]
        public Jurisdictions Jurisdictions { get; set; }

        [JsonProperty("breakdown")]
        public Breakdown Breakdown { get; set; }
    }

    public partial class Breakdown
    {
        [JsonProperty("taxable_amount")]
        public long TaxableAmount { get; set; }

        [JsonProperty("tax_collectable")]
        public double TaxCollectable { get; set; }

        [JsonProperty("combined_tax_rate")]
        public double CombinedTaxRate { get; set; }

        [JsonProperty("state_taxable_amount")]
        public long StateTaxableAmount { get; set; }

        [JsonProperty("state_tax_rate")]
        public double StateTaxRate { get; set; }

        [JsonProperty("state_tax_collectable")]
        public double StateTaxCollectable { get; set; }

        [JsonProperty("county_taxable_amount")]
        public long CountyTaxableAmount { get; set; }

        [JsonProperty("county_tax_rate")]
        public double CountyTaxRate { get; set; }

        [JsonProperty("county_tax_collectable")]
        public double CountyTaxCollectable { get; set; }

        [JsonProperty("city_taxable_amount")]
        public long CityTaxableAmount { get; set; }

        [JsonProperty("city_tax_rate")]
        public long CityTaxRate { get; set; }

        [JsonProperty("city_tax_collectable")]
        public long CityTaxCollectable { get; set; }

        [JsonProperty("special_district_taxable_amount")]
        public long SpecialDistrictTaxableAmount { get; set; }

        [JsonProperty("special_tax_rate")]
        public double SpecialTaxRate { get; set; }

        [JsonProperty("special_district_tax_collectable")]
        public double SpecialDistrictTaxCollectable { get; set; }

        [JsonProperty("line_items")]
        public LineItem[] LineItems { get; set; }
    }

    public partial class LineItem
    {
        [JsonProperty("id")]
        public long Id { get; set; }

        [JsonProperty("taxable_amount")]
        public long TaxableAmount { get; set; }

        [JsonProperty("tax_collectable")]
        public double TaxCollectable { get; set; }

        [JsonProperty("combined_tax_rate")]
        public double CombinedTaxRate { get; set; }

        [JsonProperty("state_taxable_amount")]
        public long StateTaxableAmount { get; set; }

        [JsonProperty("state_sales_tax_rate")]
        public double StateSalesTaxRate { get; set; }

        [JsonProperty("state_amount")]
        public double StateAmount { get; set; }

        [JsonProperty("county_taxable_amount")]
        public long CountyTaxableAmount { get; set; }

        [JsonProperty("county_tax_rate")]
        public double CountyTaxRate { get; set; }

        [JsonProperty("county_amount")]
        public double CountyAmount { get; set; }

        [JsonProperty("city_taxable_amount")]
        public long CityTaxableAmount { get; set; }

        [JsonProperty("city_tax_rate")]
        public long CityTaxRate { get; set; }

        [JsonProperty("city_amount")]
        public long CityAmount { get; set; }

        [JsonProperty("special_district_taxable_amount")]
        public long SpecialDistrictTaxableAmount { get; set; }

        [JsonProperty("special_tax_rate")]
        public double SpecialTaxRate { get; set; }

        [JsonProperty("special_district_amount")]
        public double SpecialDistrictAmount { get; set; }
    }

    public partial class Jurisdictions
    {
        [JsonProperty("country")]
        public string Country { get; set; }

        [JsonProperty("state")]
        public string State { get; set; }

        [JsonProperty("county")]
        public string County { get; set; }

        [JsonProperty("city")]
        public string City { get; set; }
    }
}

