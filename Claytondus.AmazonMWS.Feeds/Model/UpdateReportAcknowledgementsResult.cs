/******************************************************************************* 
 *  Copyright 2009 Amazon Services.
 *  Licensed under the Apache License, Version 2.0 (the "License"); 
 *  
 *  You may not use this file except in compliance with the License. 
 *  You may obtain a copy of the License at: http://aws.amazon.com/apache2.0
 *  This file is distributed on an "AS IS" BASIS, WITHOUT WARRANTIES OR 
 *  CONDITIONS OF ANY KIND, either express or implied. See the License for the 
 *  specific language governing permissions and limitations under the License.
 * ***************************************************************************** 
 * 
 *  Marketplace Web Service CSharp Library
 *  API Version: 2009-01-01
 *  Generated: Mon Mar 16 17:31:42 PDT 2009 
 * 
 */

using System;
using System.Xml.Serialization;
using System.Collections.Generic;
using System.Text;


namespace Claytondus.AmazonMWS.Feeds.Model
{
    [XmlTypeAttribute(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/")]
    [XmlRootAttribute(Namespace = "http://mws.amazonaws.com/doc/2009-01-01/", IsNullable = false)]
    public class UpdateReportAcknowledgementsResult
    {
    
        private Decimal? countField;

        private  List<ReportInfo> reportInfoField;


        /// <summary>
        /// Gets and sets the Count property.
        /// </summary>
        [XmlElementAttribute(ElementName = "Count")]
        public Decimal Count
        {
            get { return this.countField.GetValueOrDefault() ; }
            set { this.countField= value; }
        }



        /// <summary>
        /// Sets the Count property
        /// </summary>
        /// <param name="count">Count property</param>
        /// <returns>this instance</returns>
        public UpdateReportAcknowledgementsResult WithCount(Decimal count)
        {
            this.countField = count;
            return this;
        }



        /// <summary>
        /// Checks if Count property is set
        /// </summary>
        /// <returns>true if Count property is set</returns>
        public Boolean IsSetCount()
        {
            return  this.countField.HasValue;

        }


        /// <summary>
        /// Gets and sets the ReportInfo property.
        /// </summary>
        [XmlElementAttribute(ElementName = "ReportInfo")]
        public List<ReportInfo> ReportInfo
        {
            get
            {
                if (this.reportInfoField == null)
                {
                    this.reportInfoField = new List<ReportInfo>();
                }
                return this.reportInfoField;
            }
            set { this.reportInfoField =  value; }
        }



        /// <summary>
        /// Sets the ReportInfo property
        /// </summary>
        /// <param name="list">ReportInfo property</param>
        /// <returns>this instance</returns>
        public UpdateReportAcknowledgementsResult WithReportInfo(params ReportInfo[] list)
        {
            foreach (ReportInfo item in list)
            {
                ReportInfo.Add(item);
            }
            return this;
        }          
 


        /// <summary>
        /// Checks if ReportInfo property is set
        /// </summary>
        /// <returns>true if ReportInfo property is set</returns>
        public Boolean IsSetReportInfo()
        {
            return (ReportInfo.Count > 0);
        }




        /// <summary>
        /// XML fragment representation of this object
        /// </summary>
        /// <returns>XML fragment for this object.</returns>
        /// <remarks>
        /// Name for outer tag expected to be set by calling method. 
        /// This fragment returns inner properties representation only
        /// </remarks>


        protected internal String ToXMLFragment() {
            StringBuilder xml = new StringBuilder();
            if (IsSetCount()) {
                xml.Append("<Count>");
                xml.Append(this.Count);
                xml.Append("</Count>");
            }
            List<ReportInfo> reportInfoList = this.ReportInfo;
            foreach (ReportInfo reportInfo in reportInfoList) {
                xml.Append("<ReportInfo>");
                xml.Append(reportInfo.ToXMLFragment());
                xml.Append("</ReportInfo>");
            }
            return xml.ToString();
        }

        /**
         * 
         * Escape XML special characters
         */
        private String EscapeXML(String str) {
            StringBuilder sb = new StringBuilder();
            foreach (Char c in str)
            {
                switch (c) {
                case '&':
                    sb.Append("&amp;");
                    break;
                case '<':
                    sb.Append("&lt;");
                    break;
                case '>':
                    sb.Append("&gt;");
                    break;
                case '\'':
                    sb.Append("&#039;");
                    break;
                case '"':
                    sb.Append("&quot;");
                    break;
                default:
                    sb.Append(c);
                    break;
                }
            }
            return sb.ToString();
        }



    }

}
