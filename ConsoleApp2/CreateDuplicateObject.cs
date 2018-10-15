using System;
using System.Collections.Generic;

namespace ConsoleApp2
{
    #region == Question ==
    public class CreateDuplicateObject
    {
        private List<string> labels = new List<string>();
        private Product product;

        public CreateDuplicateObject()
        {
        }

        /// <summary>
        /// 생성자
        /// </summary>
        /// <param name="productName"></param>
        /// <param name="capacity"></param>
        /// <exception cref="ProductNameNullException">
        ///     제품명(<paramref name="productName"/>)이 null인 경우
        /// </exception>
        public CreateDuplicateObject(string productName, int capacity)
        {
            //# 1.유효성 검사를 활용
            if (productName == null)
                throw new ProductNameNullException(productName);

            labels = new List<string>(capacity);

            try
            {
                product = new Product(productName, 0);
            }
            catch (Exception e)
            {
                //# 2.예외를 복구할수 시점을 활용
                throw new ProductNameNullException(productName, e);
            }
        }
    }

    public class ProductNameNullException : Exception
    {
        private string productName;
        private Exception inner;

        public ProductNameNullException(string productName) : this(productName, null)
        {
        }

        public ProductNameNullException(string productName, Exception inner)
        {
            this.productName = productName;
            this.inner = inner;
        }
    }
    #endregion

    #region == Answer ==
    public class CreateDuplicateObjectEx
    {
        private List<string> labels;

        public CreateDuplicateObjectEx()
        {
            labels = new List<string>();
        }

        public CreateDuplicateObjectEx(int capacity)
        {
            labels = new List<string>(capacity);
        }
    } 
    #endregion
}
