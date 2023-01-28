using Gizmo.DAL.Entities;
using ProtoBuf.Meta;

namespace Gizmo.DAL
{
    /// <summary>
    /// Proto buffer setup class.
    /// </summary>
    public class ProtoSetup
    {
        /// <summary>
        /// Initialize proto buffer types.
        /// </summary>
        public static void InitTypes()
        {
            #region ENTITYBASE

            RuntimeTypeModel.Default.Add(typeof(EntityBase), true);

            RuntimeTypeModel.Default[typeof(EntityBase)]
                .AddSubType(500, typeof(CreatedByBase<UserOperator>));

            RuntimeTypeModel.Default[typeof(EntityBase)]
                .AddSubType(501, typeof(CreatedByBase<User>));

            RuntimeTypeModel.Default[typeof(EntityBase)]
                .AddSubType(502, typeof(PeriodDay));

            RuntimeTypeModel.Default[typeof(EntityBase)]
                .AddSubType(503, typeof(PeriodDate));

            RuntimeTypeModel.Default[typeof(EntityBase)]
                .AddSubType(504, typeof(AppStat));

            RuntimeTypeModel.Default[typeof(EntityBase)]
                .AddSubType(505, typeof(Log));

            RuntimeTypeModel.Default[typeof(EntityBase)]
                .AddSubType(506, typeof(LogException));

            RuntimeTypeModel.Default[typeof(EntityBase)]
               .AddSubType(507, typeof(BillRate));

            RuntimeTypeModel.Default[typeof(EntityBase)]
               .AddSubType(508, typeof(BillRateStep));

            RuntimeTypeModel.Default[typeof(EntityBase)]
                .AddSubType(509, typeof(UsageSession));

            RuntimeTypeModel.Default[typeof(EntityBase)]
                .AddSubType(510, typeof(HostGroupUserBillProfile));

            #endregion

            #region CREATEDBYBASE<USEROPERATOR>

            RuntimeTypeModel.Default[typeof(CreatedByBase<UserOperator>)]
                   .AddSubType(500, typeof(CreatedByOperatorBase));

            RuntimeTypeModel.Default[typeof(CreatedByBase<UserOperator>)]
                  .AddSubType(501, typeof(ModifiedByBase<UserOperator, User>));

            #endregion

            #region CREATEDBYBASE<USER>

            RuntimeTypeModel.Default[typeof(CreatedByBase<User>)]
                  .AddSubType(500, typeof(CreatedByUserBase));

            RuntimeTypeModel.Default[typeof(CreatedByBase<User>)]
                .AddSubType(501, typeof(ModifiedByBase<User,User>));

            #endregion

            #region MODIFIEDBYBASE<USEROPERATOR,USER>
            RuntimeTypeModel.Default[typeof(ModifiedByBase<UserOperator, User>)]
                    .AddSubType(500, typeof(HostGroupWaitingLineEntry)); 
            #endregion

            #region MODIFIEDBYBASE<USER,USER>

            RuntimeTypeModel.Default[typeof(ModifiedByBase<User,User>)]
                .AddSubType(500, typeof(ModifiableByUserCreatedByUserBase));

            #endregion

            #region MODIFIABLEBYUSERCREATEDBYUSERBASE

            RuntimeTypeModel.Default[typeof(ModifiableByUserCreatedByUserBase)]
                .AddSubType(500, typeof(UserPicture));

            #endregion

            #region CREATEDBYOPERATORBASE

            RuntimeTypeModel.Default[typeof(CreatedByOperatorBase)]
                .AddSubType(501, typeof(ModifiableByOperatorBase));

            RuntimeTypeModel.Default[typeof(CreatedByOperatorBase)]
                .AddSubType(502, typeof(ModifiableByUserBase));

            RuntimeTypeModel.Default[typeof(CreatedByOperatorBase)]
                .AddSubType(503, typeof(EntityWithShift));

            #endregion

            #region ENTITYWITHSHIFT

            RuntimeTypeModel.Default[typeof(EntityWithShift)]
                .AddSubType(501, typeof(Refund));

            RuntimeTypeModel.Default[typeof(EntityWithShift)]
                .AddSubType(502, typeof(Entities.Void));

            #endregion

            #region CREATEDBYUSERBASE

            RuntimeTypeModel.Default[typeof(CreatedByUserBase)]
              .AddSubType(500, typeof(UserSession));
            RuntimeTypeModel.Default[typeof(CreatedByUserBase)]
                .AddSubType(501, typeof(UserSessionChange));

            #endregion

            #region MODIFIABLEBYUSERBASE  

            RuntimeTypeModel.Default[typeof(ModifiableByUserBase)]
                .AddSubType(500, typeof(User));

            #endregion

            #region USER

            RuntimeTypeModel.Default[typeof(User)]
                   .AddSubType(500, typeof(UserMember));

            RuntimeTypeModel.Default[typeof(User)]
                .AddSubType(501, typeof(UserOperator));

            #endregion

            #region USERMEMBER

            RuntimeTypeModel.Default[typeof(UserMember)]
                .AddSubType(500, typeof(UserGuest));

            #endregion

            #region IMAGEBASE

            RuntimeTypeModel.Default[typeof(ImageBase)]
                .AddSubType(500, typeof(ProductImage));
            RuntimeTypeModel.Default[typeof(ImageBase)]
                .AddSubType(501, typeof(AppImage));
            RuntimeTypeModel.Default[typeof(ImageBase)]
                .AddSubType(502, typeof(Icon));
            RuntimeTypeModel.Default[typeof(ImageBase)]
               .AddSubType(503, typeof(HostLayoutGroupImage));
            #endregion

            #region PRICEBASE

            RuntimeTypeModel.Default[typeof(PriceBase)]
                   .AddSubType(500, typeof(UserGroupPriceBase));

            #endregion

            #region USERGROUPPRICEBASE

            RuntimeTypeModel.Default[typeof(UserGroupPriceBase)]
                .AddSubType(500, typeof(ProductUserPrice));

            #endregion

            #region PRODUCTBASE

            RuntimeTypeModel.Default[typeof(ProductBase)]
              .AddSubType(500, typeof(ProductBaseExtended));
            RuntimeTypeModel.Default[typeof(ProductBase)]
                .AddSubType(501, typeof(ProductTime));

            #endregion

            #region PRODUCTBASEEXTENDED

            RuntimeTypeModel.Default[typeof(ProductBaseExtended)]
                 .AddSubType(500, typeof(Product));
            RuntimeTypeModel.Default[typeof(ProductBaseExtended)]
                .AddSubType(501, typeof(ProductBundle));

            #endregion

            #region PERIODDATE

            RuntimeTypeModel.Default[typeof(PeriodDate)]
             .AddSubType(500, typeof(ProductPeriod));
            RuntimeTypeModel.Default[typeof(PeriodDate)]
                .AddSubType(501, typeof(ProductTimePeriod));

            #endregion

            #region PERIODDAY

            RuntimeTypeModel.Default[typeof(PeriodDay)]
                .AddSubType(500, typeof(ProductPeriodDay));
            RuntimeTypeModel.Default[typeof(PeriodDay)]
                .AddSubType(501, typeof(ProductTimePeriodDay));
            RuntimeTypeModel.Default[typeof(PeriodDay)]
                .AddSubType(502, typeof(BillRatePeriodDay));

            #endregion

            #region PERIODDAYTIME     

            RuntimeTypeModel.Default[typeof(PeriodDayTime)]
                .AddSubType(500, typeof(ProductPeriodDayTime));
            RuntimeTypeModel.Default[typeof(PeriodDayTime)]
                .AddSubType(501, typeof(ProductTimePeriodDayTime));
            RuntimeTypeModel.Default[typeof(PeriodDayTime)]
                .AddSubType(502, typeof(BillRatePeriodDayTime));

            #endregion

            #region INVOICELINE

            RuntimeTypeModel.Default[typeof(InvoiceLine)]
                .AddSubType(500, typeof(InvoiceLineExtended));
            RuntimeTypeModel.Default[typeof(InvoiceLine)]
                .AddSubType(501, typeof(InvoiceLineTimeFixed));
            RuntimeTypeModel.Default[typeof(InvoiceLine)]
                .AddSubType(502, typeof(InvoiceLineSession));

            #endregion

            #region INVOICELINEEXTENDED

            RuntimeTypeModel.Default[typeof(InvoiceLineExtended)]
                 .AddSubType(500, typeof(InvoiceLineProduct));
            RuntimeTypeModel.Default[typeof(InvoiceLineExtended)]
                .AddSubType(501, typeof(InvoiceLineTime));

            #endregion            

            #region HOST

            RuntimeTypeModel.Default[typeof(Host)]
                  .AddSubType(500, typeof(HostComputer));
            RuntimeTypeModel.Default[typeof(Host)]
                .AddSubType(501, typeof(HostEndpoint));

            #endregion

            #region PRODUCT ORDER LINE

            RuntimeTypeModel.Default[typeof(ProductOL)].AddSubType(500, typeof(ProductOLExtended));
            RuntimeTypeModel.Default[typeof(ProductOL)].AddSubType(501, typeof(ProductOLTimeFixed));
            RuntimeTypeModel.Default[typeof(ProductOL)].AddSubType(502, typeof(ProductOLSession));

            RuntimeTypeModel.Default[typeof(ProductOLExtended)].AddSubType(500, typeof(ProductOLTime));
            RuntimeTypeModel.Default[typeof(ProductOLExtended)].AddSubType(501, typeof(ProductOLProduct));

            #endregion

            #region TASK BASE

            RuntimeTypeModel.Default[typeof(TaskBase)]
                .AddSubType(500, typeof(TaskScript));
            RuntimeTypeModel.Default[typeof(TaskBase)]
              .AddSubType(501, typeof(TaskProcess));
            RuntimeTypeModel.Default[typeof(TaskBase)]
              .AddSubType(502, typeof(TaskNotification));
            RuntimeTypeModel.Default[typeof(TaskBase)]
              .AddSubType(503, typeof(TaskJunction));

            #endregion

            #region NOTE
            RuntimeTypeModel.Default[typeof(Note)]
                .AddSubType(500, typeof(UserNote));
            #endregion         

            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(500, typeof(UserPermission));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(501, typeof(UserAttribute));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(502, typeof(Host));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(503, typeof(ProductGroup));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(504, typeof(Tax));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(505, typeof(ProductTax));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(506, typeof(PaymentMethod));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(507, typeof(MonetaryUnit));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(508, typeof(StockTransaction));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(509, typeof(ProductBase));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(510, typeof(BundleProductUserPrice));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(561, typeof(ProductBundleUserPrice));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(511, typeof(BundleProduct));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(512, typeof(ProductUserDisallowed));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(513, typeof(ProductTimeHostDisallowed));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(514, typeof(FileListEntityBase));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(515, typeof(BillProfile));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(516, typeof(Entities.Attribute));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(517, typeof(HostLayoutGroup));

            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(519, typeof(HostLayoutGroupLayout));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(520, typeof(HostGroup));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(521, typeof(UserCreditLimit));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(522, typeof(UserGroupHostDisallowed));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(523, typeof(UserGroup));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(524, typeof(ClientTask));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(525, typeof(License));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(526, typeof(LicenseKey));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(527, typeof(DeploymentDeployment));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(528, typeof(PluginLibrary));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(529, typeof(Variable));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(530, typeof(Mapping));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(531, typeof(Feed));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(532, typeof(News));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(533, typeof(Setting));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(534, typeof(HostGroup));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(535, typeof(SecurityProfile));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(536, typeof(SecurityProfilePolicy));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(537, typeof(SecurityProfileRestriction));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(538, typeof(AppCategory));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(539, typeof(AppEnterprise));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(540, typeof(AppGroup));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(541, typeof(App));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(542, typeof(AppExeDeployment));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(543, typeof(AppExePersonalFile));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(544, typeof(AppExeLicense));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(545, typeof(AppExeTask));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(546, typeof(AppExeCdImage));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(547, typeof(AppExeMaxUser));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(548, typeof(AppExe));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(549, typeof(AppLink));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(550, typeof(Note));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(551, typeof(TaskBase));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(552, typeof(ImageBase));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(553, typeof(PriceBase));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(554, typeof(ModifiableByWithRequiredUserMemberBase));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(555, typeof(Register));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(556, typeof(Shift));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(557, typeof(ShiftCount));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(558, typeof(RegisterTransaction));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(559, typeof(AssetType));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(560, typeof(Asset));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(562, typeof(HostGroupWaitingLine));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(563, typeof(ProductHostHidden));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(564, typeof(Device));
            RuntimeTypeModel.Default[typeof(ModifiableByOperatorBase)].AddSubType(565, typeof(DeviceHost));


            RuntimeTypeModel.Default[typeof(FileListEntityBase)].AddSubType(500, typeof(PersonalFile));
            RuntimeTypeModel.Default[typeof(FileListEntityBase)].AddSubType(501, typeof(Deployment));

            RuntimeTypeModel.Default[typeof(ModifiableByWithRequiredUserMemberBase)].AddSubType(500, typeof(ProductOL));
            RuntimeTypeModel.Default[typeof(ModifiableByWithRequiredUserMemberBase)].AddSubType(501, typeof(InvoiceLine));
            RuntimeTypeModel.Default[typeof(ModifiableByWithRequiredUserMemberBase)].AddSubType(502, typeof(Payment));
            RuntimeTypeModel.Default[typeof(ModifiableByWithRequiredUserMemberBase)].AddSubType(503, typeof(Invoice));
            RuntimeTypeModel.Default[typeof(ModifiableByWithRequiredUserMemberBase)].AddSubType(504, typeof(InvoicePayment));
            RuntimeTypeModel.Default[typeof(ModifiableByWithRequiredUserMemberBase)].AddSubType(505, typeof(DepositPayment));
            RuntimeTypeModel.Default[typeof(ModifiableByWithRequiredUserMemberBase)].AddSubType(506, typeof(DepositTransaction));
            RuntimeTypeModel.Default[typeof(ModifiableByWithRequiredUserMemberBase)].AddSubType(507, typeof(ProductOrder));
            RuntimeTypeModel.Default[typeof(ModifiableByWithRequiredUserMemberBase)].AddSubType(561, typeof(AssetTransaction));            

            RuntimeTypeModel.Default[typeof(Refund)].AddSubType(501, typeof(RefundInvoicePayment));

            RuntimeTypeModel.Default[typeof(Void)].AddSubType(501, typeof(VoidInvoice));
        }
    }
}
