﻿namespace phone_dataset_builder
{
    public struct phone_brand
    {
        public string brand;
        public string model_no;
        public string url;

        // Constructor:
        public phone_brand(string brand, string model_no, string url)
        {
            this.brand = brand;
            this.model_no = model_no;
            this.url = url;
        }
    }
}