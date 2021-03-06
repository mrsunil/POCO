//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using System.Data.Entity.Infrastructure.MappingViews;

[assembly: DbMappingViewCacheTypeAttribute(
    typeof(POCO.ApprovalFlow_UpdEntities),
    typeof(Edm_EntityMappingGeneratedViews.ViewsForBaseEntitySets25890ba30a8aae5718edecdf66425ed09ac2899fc86b5901a91d603240cc58e2))]

namespace Edm_EntityMappingGeneratedViews
{
    using System;
    using System.CodeDom.Compiler;
    using System.Data.Entity.Core.Metadata.Edm;

    /// <summary>
    /// Implements a mapping view cache.
    /// </summary>
    [GeneratedCode("Entity Framework 6 Power Tools", "0.9.2.0")]
    internal sealed class ViewsForBaseEntitySets25890ba30a8aae5718edecdf66425ed09ac2899fc86b5901a91d603240cc58e2 : DbMappingViewCache
    {
        /// <summary>
        /// Gets a hash value computed over the mapping closure.
        /// </summary>
        public override string MappingHashValue
        {
            get { return "25890ba30a8aae5718edecdf66425ed09ac2899fc86b5901a91d603240cc58e2"; }
        }

        /// <summary>
        /// Gets a view corresponding to the specified extent.
        /// </summary>
        /// <param name="extent">The extent.</param>
        /// <returns>The mapping view, or null if the extent is not associated with a mapping view.</returns>
        public override DbMappingView GetView(EntitySetBase extent)
        {
            if (extent == null)
            {
                throw new ArgumentNullException("extent");
            }

            var extentName = extent.EntityContainer.Name + "." + extent.Name;

            if (extentName == "ApprovalFlow_UpdModelStoreContainer.Approve")
            {
                return GetView0();
            }

            if (extentName == "ApprovalFlow_UpdModelStoreContainer.ApproveHistory")
            {
                return GetView1();
            }

            if (extentName == "ApprovalFlow_UpdModelStoreContainer.Employee")
            {
                return GetView2();
            }

            if (extentName == "ApprovalFlow_UpdModelStoreContainer.ResponsibilityCodeHierarchy")
            {
                return GetView3();
            }

            if (extentName == "ApprovalFlow_UpdModelStoreContainer.SecurityContact")
            {
                return GetView4();
            }

            if (extentName == "ApprovalFlow_UpdModelStoreContainer.SecurityContactResponsibilityCode")
            {
                return GetView5();
            }

            if (extentName == "ApprovalFlow_UpdEntities.Approves")
            {
                return GetView6();
            }

            if (extentName == "ApprovalFlow_UpdEntities.ApproveHistories")
            {
                return GetView7();
            }

            if (extentName == "ApprovalFlow_UpdEntities.Employees")
            {
                return GetView8();
            }

            if (extentName == "ApprovalFlow_UpdEntities.ResponsibilityCodeHierarchies")
            {
                return GetView9();
            }

            if (extentName == "ApprovalFlow_UpdEntities.SecurityContacts")
            {
                return GetView10();
            }

            if (extentName == "ApprovalFlow_UpdEntities.SecurityContactResponsibilityCodes")
            {
                return GetView11();
            }

            return null;
        }

        /// <summary>
        /// Gets the view for ApprovalFlow_UpdModelStoreContainer.Approve.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView0()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Approve
        [ApprovalFlow_UpdModel.Store.Approve](T1.Approve_ApproveId, T1.Approve_HierarchyId, T1.Approve_Dfr, T1.Approve_Lcfo, T1.Approve_IsEffective, T1.Approve_EfffectiveDate, T1.Approve_ExpirationDate, T1.Approve_CreatedBy, T1.Approve_CreatedDate, T1.Approve_UpdatedBy, T1.Approve_UpdatedDate, T1.Approve_IsActive)
    FROM (
        SELECT 
            T.ApproveId AS Approve_ApproveId, 
            T.HierarchyId AS Approve_HierarchyId, 
            T.Dfr AS Approve_Dfr, 
            T.Lcfo AS Approve_Lcfo, 
            T.IsEffective AS Approve_IsEffective, 
            T.EfffectiveDate AS Approve_EfffectiveDate, 
            T.ExpirationDate AS Approve_ExpirationDate, 
            T.CreatedBy AS Approve_CreatedBy, 
            T.CreatedDate AS Approve_CreatedDate, 
            T.UpdatedBy AS Approve_UpdatedBy, 
            T.UpdatedDate AS Approve_UpdatedDate, 
            T.IsActive AS Approve_IsActive, 
            True AS _from0
        FROM ApprovalFlow_UpdEntities.Approves AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for ApprovalFlow_UpdModelStoreContainer.ApproveHistory.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView1()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing ApproveHistory
        [ApprovalFlow_UpdModel.Store.ApproveHistory](T1.ApproveHistory_ApproveHistoryId, T1.ApproveHistory_ApproveId, T1.ApproveHistory_PreviousDfr, T1.ApproveHistory_PreviousLcfo, T1.ApproveHistory_CreatedBy, T1.ApproveHistory_CreatedDate)
    FROM (
        SELECT 
            T.ApproveHistoryId AS ApproveHistory_ApproveHistoryId, 
            T.ApproveId AS ApproveHistory_ApproveId, 
            T.PreviousDfr AS ApproveHistory_PreviousDfr, 
            T.PreviousLcfo AS ApproveHistory_PreviousLcfo, 
            T.CreatedBy AS ApproveHistory_CreatedBy, 
            T.CreatedDate AS ApproveHistory_CreatedDate, 
            True AS _from0
        FROM ApprovalFlow_UpdEntities.ApproveHistories AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for ApprovalFlow_UpdModelStoreContainer.Employee.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView2()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Employee
        [ApprovalFlow_UpdModel.Store.Employee](T1.Employee_EmployeeId, T1.Employee_nTic, T1.Employee_Name, T1.Employee_EmailId, T1.Employee_Division, T1.Employee_IsDFR, T1.Employee_IsLCFO, T1.Employee_IsActive)
    FROM (
        SELECT 
            T.EmployeeId AS Employee_EmployeeId, 
            T.nTic AS Employee_nTic, 
            T.Name AS Employee_Name, 
            T.EmailId AS Employee_EmailId, 
            T.Division AS Employee_Division, 
            T.IsDFR AS Employee_IsDFR, 
            T.IsLCFO AS Employee_IsLCFO, 
            T.IsActive AS Employee_IsActive, 
            True AS _from0
        FROM ApprovalFlow_UpdEntities.Employees AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for ApprovalFlow_UpdModelStoreContainer.ResponsibilityCodeHierarchy.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView3()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing ResponsibilityCodeHierarchy
        [ApprovalFlow_UpdModel.Store.ResponsibilityCodeHierarchy](T1.ResponsibilityCodeHierarchy_HierarchyId, T1.ResponsibilityCodeHierarchy_ResponsibilityCode, T1.ResponsibilityCodeHierarchy_ParentCode, T1.ResponsibilityCodeHierarchy_CreatedBy, T1.ResponsibilityCodeHierarchy_CreatedDate, T1.ResponsibilityCodeHierarchy_UpdatedBy, T1.ResponsibilityCodeHierarchy_UpdatedDate, T1.ResponsibilityCodeHierarchy_IsActive)
    FROM (
        SELECT 
            T.HierarchyId AS ResponsibilityCodeHierarchy_HierarchyId, 
            T.ResponsibilityCode AS ResponsibilityCodeHierarchy_ResponsibilityCode, 
            T.ParentCode AS ResponsibilityCodeHierarchy_ParentCode, 
            T.CreatedBy AS ResponsibilityCodeHierarchy_CreatedBy, 
            T.CreatedDate AS ResponsibilityCodeHierarchy_CreatedDate, 
            T.UpdatedBy AS ResponsibilityCodeHierarchy_UpdatedBy, 
            T.UpdatedDate AS ResponsibilityCodeHierarchy_UpdatedDate, 
            T.IsActive AS ResponsibilityCodeHierarchy_IsActive, 
            True AS _from0
        FROM ApprovalFlow_UpdEntities.ResponsibilityCodeHierarchies AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for ApprovalFlow_UpdModelStoreContainer.SecurityContact.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView4()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing SecurityContact
        [ApprovalFlow_UpdModel.Store.SecurityContact](T1.SecurityContact_SecurityContactId, T1.SecurityContact_nTic, T1.SecurityContact_Name, T1.SecurityContact_EmailId, T1.SecurityContact_Division, T1.SecurityContact_Department, T1.SecurityContact_IsActive)
    FROM (
        SELECT 
            T.SecurityContactId AS SecurityContact_SecurityContactId, 
            T.nTic AS SecurityContact_nTic, 
            T.Name AS SecurityContact_Name, 
            T.EmailId AS SecurityContact_EmailId, 
            T.Division AS SecurityContact_Division, 
            T.Department AS SecurityContact_Department, 
            T.IsActive AS SecurityContact_IsActive, 
            True AS _from0
        FROM ApprovalFlow_UpdEntities.SecurityContacts AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for ApprovalFlow_UpdModelStoreContainer.SecurityContactResponsibilityCode.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView5()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing SecurityContactResponsibilityCode
        [ApprovalFlow_UpdModel.Store.SecurityContactResponsibilityCode](T1.SecurityContactResponsibilityCode_SecurityContactResponsibilityCodeId, T1.SecurityContactResponsibilityCode_SecurityContactId, T1.SecurityContactResponsibilityCode_HierarchyId)
    FROM (
        SELECT 
            T.SecurityContactResponsibilityCodeId AS SecurityContactResponsibilityCode_SecurityContactResponsibilityCodeId, 
            T.SecurityContactId AS SecurityContactResponsibilityCode_SecurityContactId, 
            T.HierarchyId AS SecurityContactResponsibilityCode_HierarchyId, 
            True AS _from0
        FROM ApprovalFlow_UpdEntities.SecurityContactResponsibilityCodes AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for ApprovalFlow_UpdEntities.Approves.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView6()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Approves
        [ApprovalFlow_UpdModel.Approve](T1.Approve_ApproveId, T1.Approve_HierarchyId, T1.Approve_Dfr, T1.Approve_Lcfo, T1.Approve_IsEffective, T1.Approve_EfffectiveDate, T1.Approve_ExpirationDate, T1.Approve_CreatedBy, T1.Approve_CreatedDate, T1.Approve_UpdatedBy, T1.Approve_UpdatedDate, T1.Approve_IsActive)
    FROM (
        SELECT 
            T.ApproveId AS Approve_ApproveId, 
            T.HierarchyId AS Approve_HierarchyId, 
            T.Dfr AS Approve_Dfr, 
            T.Lcfo AS Approve_Lcfo, 
            T.IsEffective AS Approve_IsEffective, 
            T.EfffectiveDate AS Approve_EfffectiveDate, 
            T.ExpirationDate AS Approve_ExpirationDate, 
            T.CreatedBy AS Approve_CreatedBy, 
            T.CreatedDate AS Approve_CreatedDate, 
            T.UpdatedBy AS Approve_UpdatedBy, 
            T.UpdatedDate AS Approve_UpdatedDate, 
            T.IsActive AS Approve_IsActive, 
            True AS _from0
        FROM ApprovalFlow_UpdModelStoreContainer.Approve AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for ApprovalFlow_UpdEntities.ApproveHistories.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView7()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing ApproveHistories
        [ApprovalFlow_UpdModel.ApproveHistory](T1.ApproveHistory_ApproveHistoryId, T1.ApproveHistory_ApproveId, T1.ApproveHistory_PreviousDfr, T1.ApproveHistory_PreviousLcfo, T1.ApproveHistory_CreatedBy, T1.ApproveHistory_CreatedDate)
    FROM (
        SELECT 
            T.ApproveHistoryId AS ApproveHistory_ApproveHistoryId, 
            T.ApproveId AS ApproveHistory_ApproveId, 
            T.PreviousDfr AS ApproveHistory_PreviousDfr, 
            T.PreviousLcfo AS ApproveHistory_PreviousLcfo, 
            T.CreatedBy AS ApproveHistory_CreatedBy, 
            T.CreatedDate AS ApproveHistory_CreatedDate, 
            True AS _from0
        FROM ApprovalFlow_UpdModelStoreContainer.ApproveHistory AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for ApprovalFlow_UpdEntities.Employees.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView8()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing Employees
        [ApprovalFlow_UpdModel.Employee](T1.Employee_EmployeeId, T1.Employee_nTic, T1.Employee_Name, T1.Employee_EmailId, T1.Employee_Division, T1.Employee_IsDFR, T1.Employee_IsLCFO, T1.Employee_IsActive)
    FROM (
        SELECT 
            T.EmployeeId AS Employee_EmployeeId, 
            T.nTic AS Employee_nTic, 
            T.Name AS Employee_Name, 
            T.EmailId AS Employee_EmailId, 
            T.Division AS Employee_Division, 
            T.IsDFR AS Employee_IsDFR, 
            T.IsLCFO AS Employee_IsLCFO, 
            T.IsActive AS Employee_IsActive, 
            True AS _from0
        FROM ApprovalFlow_UpdModelStoreContainer.Employee AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for ApprovalFlow_UpdEntities.ResponsibilityCodeHierarchies.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView9()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing ResponsibilityCodeHierarchies
        [ApprovalFlow_UpdModel.ResponsibilityCodeHierarchy](T1.ResponsibilityCodeHierarchy_HierarchyId, T1.ResponsibilityCodeHierarchy_ResponsibilityCode, T1.ResponsibilityCodeHierarchy_ParentCode, T1.ResponsibilityCodeHierarchy_CreatedBy, T1.ResponsibilityCodeHierarchy_CreatedDate, T1.ResponsibilityCodeHierarchy_UpdatedBy, T1.ResponsibilityCodeHierarchy_UpdatedDate, T1.ResponsibilityCodeHierarchy_IsActive)
    FROM (
        SELECT 
            T.HierarchyId AS ResponsibilityCodeHierarchy_HierarchyId, 
            T.ResponsibilityCode AS ResponsibilityCodeHierarchy_ResponsibilityCode, 
            T.ParentCode AS ResponsibilityCodeHierarchy_ParentCode, 
            T.CreatedBy AS ResponsibilityCodeHierarchy_CreatedBy, 
            T.CreatedDate AS ResponsibilityCodeHierarchy_CreatedDate, 
            T.UpdatedBy AS ResponsibilityCodeHierarchy_UpdatedBy, 
            T.UpdatedDate AS ResponsibilityCodeHierarchy_UpdatedDate, 
            T.IsActive AS ResponsibilityCodeHierarchy_IsActive, 
            True AS _from0
        FROM ApprovalFlow_UpdModelStoreContainer.ResponsibilityCodeHierarchy AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for ApprovalFlow_UpdEntities.SecurityContacts.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView10()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing SecurityContacts
        [ApprovalFlow_UpdModel.SecurityContact](T1.SecurityContact_SecurityContactId, T1.SecurityContact_nTic, T1.SecurityContact_Name, T1.SecurityContact_EmailId, T1.SecurityContact_Division, T1.SecurityContact_Department, T1.SecurityContact_IsActive)
    FROM (
        SELECT 
            T.SecurityContactId AS SecurityContact_SecurityContactId, 
            T.nTic AS SecurityContact_nTic, 
            T.Name AS SecurityContact_Name, 
            T.EmailId AS SecurityContact_EmailId, 
            T.Division AS SecurityContact_Division, 
            T.Department AS SecurityContact_Department, 
            T.IsActive AS SecurityContact_IsActive, 
            True AS _from0
        FROM ApprovalFlow_UpdModelStoreContainer.SecurityContact AS T
    ) AS T1");
        }

        /// <summary>
        /// Gets the view for ApprovalFlow_UpdEntities.SecurityContactResponsibilityCodes.
        /// </summary>
        /// <returns>The mapping view.</returns>
        private static DbMappingView GetView11()
        {
            return new DbMappingView(@"
    SELECT VALUE -- Constructing SecurityContactResponsibilityCodes
        [ApprovalFlow_UpdModel.SecurityContactResponsibilityCode](T1.SecurityContactResponsibilityCode_SecurityContactResponsibilityCodeId, T1.SecurityContactResponsibilityCode_SecurityContactId, T1.SecurityContactResponsibilityCode_HierarchyId)
    FROM (
        SELECT 
            T.SecurityContactResponsibilityCodeId AS SecurityContactResponsibilityCode_SecurityContactResponsibilityCodeId, 
            T.SecurityContactId AS SecurityContactResponsibilityCode_SecurityContactId, 
            T.HierarchyId AS SecurityContactResponsibilityCode_HierarchyId, 
            True AS _from0
        FROM ApprovalFlow_UpdModelStoreContainer.SecurityContactResponsibilityCode AS T
    ) AS T1");
        }
    }
}
