using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using Microsoft.Win32.SafeHandles;
using System.Runtime.InteropServices;

namespace GG.Base
{
    [Serializable()]
    public class BusinessObject : INotifyPropertyChanged, ICloneable, IDisposable
    {
        public static readonly String DefaultString = string.Empty;
        public const int DefaultNumber = 0;
        public static readonly DateTime DefaultInactiveDate = DateTime.MaxValue;
        public static readonly DateTime DefaultDate = DateTime.Now;
        public static readonly String DefaultStatus = "New";        
        public static readonly String DefaultAAStatus = "Alive";
        public static readonly String ResignedStatus = "Resigned";
        public static readonly string InactiveStatus = "Inactive";
        public static readonly String DeletedAAStatus = "Delete";
        public static readonly string TemplateAAStatus = "Template";
        public static readonly String DefaultActive = "true";

        public enum ObjectStatus
        {
            New=0,
            Alive=1,
            Delete=2
        }

        public List<BusinessRule> BusinessRuleCollections;
        
        /// <summary>
        /// Constructor.
        /// </summary>
        public BusinessObject()
        {
            BusinessRuleCollections = new List<BusinessRule>();
            Selected = false;
            AllowPropertyChangedEvent = true;
            TheNumberOfChild = 0;
        }

        #region Public Properties
        public bool AllowPropertyChangedEvent { get; set; }

        public int Position {get;set;}

        public int RelatedPosition {get;set;}

        public bool Selected { get; set; }

        public int TheNumberOfChild { get; set; }

        /// <summary>
        /// Gets or sets the old object of the current one each time it's
        /// saved to database
        /// </summary>
        public BusinessObject OldObject { get; set; }

        /// <summary>
        /// Gets or sets the back-up object for rolling back
        /// </summary>
        public BusinessObject BackupObject { get; set; }
        #endregion
        #region Implement Dispose
        // Flag: Has Dispose already been called?
        bool disposed = false;
        // Instantiate a SafeHandle instance.
        SafeHandle handle = new SafeFileHandle(IntPtr.Zero, true);

        // Public implementation of Dispose pattern callable by consumers.
        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }

        // Protected implementation of Dispose pattern.
        protected virtual void Dispose(bool disposing)
        {
            if (disposed)
                return;

            if (disposing)
            {
                handle.Dispose();
                // Free any other managed objects here.
                //
            }

            disposed = true;
        }
        #endregion
        public virtual List<BusinessRule> CreateRules()
        {
            return new List<BusinessRule>();
        }

        protected BusinessRule GetBusinessRule(string propertyName)
        {
            BusinessRule businessRule = new BusinessRule();
            foreach (BusinessRule r in BusinessRuleCollections)
            {
                if (r.PropertyName == propertyName)
                {
                    businessRule = r;
                    break;
                }
            }
            return businessRule;
        }


        /// <summary>
        /// Validates all rules on this domain object for a given property, returning a list of the broken rules.
        /// </summary>
        /// <param name="property">The name of the property to check for. If null or empty, all rules will be checked.</param>
        /// <returns>A read-only collection of rules that have been broken.</returns>
        public virtual ReadOnlyCollection<BusinessRule> GetBrokenRules(string property)
        {
            property = CleanString(property);

            // If we haven't yet created the rules, create them now.
            if (BusinessRuleCollections == null)
            {
                BusinessRuleCollections = new List<BusinessRule>();
                BusinessRuleCollections.AddRange(this.CreateRules());
            }
            List<BusinessRule> broken = new List<BusinessRule>();

            foreach (BusinessRule r in this.BusinessRuleCollections)
            {
                if (r.PropertyName == property || property == string.Empty)
                {
                    bool isRuleBroken = !r.ValidateRule(this);                    
                    if (isRuleBroken)
                    {                        
                        broken.Add(r);                        
                    }                    
                }
            }

            return broken.AsReadOnly();
        }


        /// <summary>
        /// Cleans a string by ensuring it isn't null and trimming it.
        /// </summary>
        /// <param name="s">The string to clean.</param>
        protected string CleanString(string s)
        {
            return (s ?? string.Empty).Trim();
        }

        #region "Event, delegate functions"

        public delegate void EventHandler(object sender, EventArgs e);
        //public event EventHandler OnValid;
        //public event EventHandler OnInvalid;
        //public event EventHandler OnChanged;
        
        public void RaiseEvent(EventHandler handler, EventArgs e)
        {
            if (handler != null)
            {
                handler(this, e);
            }
        }
        /// <summary>
        /// Occurs when any properties are changed on this object.
        /// </summary>
        public event PropertyChangedEventHandler PropertyChanged;

        
        /// <summary>
        /// Raises the PropertyChanged event.
        /// </summary>
        /// <param name="e">Event arguments.</param>
        protected virtual void OnPropertyChanged(PropertyChangedEventArgs e)
        {                     
            if (this.PropertyChanged != null)
            {
                this.PropertyChanged(this, e);                
            }
        }

        protected virtual void NotifyChanged(params string[] propertyNames)
        {
            foreach (string name in propertyNames)
            {
                OnPropertyChanged(new PropertyChangedEventArgs(name));                
            }
        }

        #endregion


        #region ICloneable Members

        public object Clone()
        {
            try
            {
                return this.MemberwiseClone();
            }
            catch (Exception ex)
            {
                disposed = false;
                Dispose(true);
                GC.SuppressFinalize(this);
                throw ex;
            }

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public object CloneAndDispose()
        {
            try
            {
                var obj = this.MemberwiseClone();
                disposed = false;
                Dispose(true);
                return obj;
            }
            catch (Exception ex)
            {
                disposed = false;
                Dispose(true);
                GC.SuppressFinalize(this);
                throw ex;
            }

        }

        #endregion
        
    }
}
