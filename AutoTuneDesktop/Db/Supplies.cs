//------------------------------------------------------------------------------
// <auto-generated>
//     Этот код создан по шаблону.
//
//     Изменения, вносимые в этот файл вручную, могут привести к непредвиденной работе приложения.
//     Изменения, вносимые в этот файл вручную, будут перезаписаны при повторном создании кода.
// </auto-generated>
//------------------------------------------------------------------------------

namespace AutoTuneDesktop.Db
{
    using System;
    using System.Collections.Generic;
    
    public partial class Supplies
    {
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2214:DoNotCallOverridableMethodsInConstructors")]
        public Supplies()
        {
            this.MaterialsToSupplies = new HashSet<MaterialsToSupplies>();
        }
    
        public int ID { get; set; }
        public int IDSupplier { get; set; }
        public System.DateTime SupplyDate { get; set; }
        public int IdStatusSupply { get; set; }
        public Nullable<decimal> Cost { get; set; }
    
        [System.Diagnostics.CodeAnalysis.SuppressMessage("Microsoft.Usage", "CA2227:CollectionPropertiesShouldBeReadOnly")]
        public virtual ICollection<MaterialsToSupplies> MaterialsToSupplies { get; set; }
        public virtual Suppliers Suppliers { get; set; }
        public virtual SupplyStatuses SupplyStatuses { get; set; }
    }
}
