namespace Allors.Domain
{
		public interface Object 
		{
		}
		public interface Cachable  : Object 
		{
						global::System.Guid CacheId {set;}

		}
		public interface Deletable  : Object 
		{
		}
		public interface Enumeration  : AccessControlledObject, UniquelyIdentifiable 
		{
						global::System.String Name {set;}

						LocalisedText LocalisedNames {set;}

						global::System.Boolean? IsActive {set;}

		}
		public interface UniquelyIdentifiable  : Object 
		{
						global::System.Guid UniqueId {set;}

		}
		public interface Version  : AccessControlledObject 
		{
						global::System.Guid? DerivationId {set;}

						global::System.DateTime? DerivationTimeStamp {set;}

		}
		public interface Versioned  : Object 
		{
		}
		public interface Localised  : Object 
		{
						Locale Locale {set;}

		}
		public interface AccessControlledObject  : Object 
		{
						Permission DeniedPermissions {set;}

						SecurityToken SecurityTokens {set;}

		}
		public interface DelegatedAccessControlledObject  : AccessControlledObject 
		{
		}
		public interface SecurityTokenOwner  : Object 
		{
						SecurityToken OwnerSecurityToken {set;}

						AccessControl OwnerAccessControl {set;}

		}
		public interface ObjectState  : UniquelyIdentifiable 
		{
						Permission DeniedPermissions {set;}

						global::System.String Name {set;}

		}
		public interface Task  : AccessControlledObject, UniquelyIdentifiable, Deletable 
		{
						WorkItem WorkItem {set;}

						global::System.DateTime DateCreated {set;}

						global::System.DateTime? DateClosed {set;}

						Person Participants {set;}

						Person Performer {set;}

		}
		public interface Transitional  : AccessControlledObject 
		{
						ObjectState PreviousObjectStates {set;}

						ObjectState LastObjectStates {set;}

						ObjectState ObjectStates {set;}

		}
		public interface TransitionalVersion  : AccessControlledObject 
		{
						ObjectState PreviousObjectStates {set;}

						ObjectState LastObjectStates {set;}

						ObjectState ObjectStates {set;}

		}
		public interface User  : SecurityTokenOwner, AccessControlledObject 
		{
						global::System.String UserName {set;}

						global::System.String NormalizedUserName {set;}

						global::System.String UserPasswordHash {set;}

						global::System.String UserEmail {set;}

						global::System.Boolean? UserEmailConfirmed {set;}

						TaskList TaskList {set;}

						NotificationList NotificationList {set;}

		}
		public interface WorkItem  : Object 
		{
						global::System.String WorkItemDescription {set;}

		}
		public interface Employment  : AccessControlledObject, Deletable 
		{
						Organisation Employer {set;}

						Person Employee {set;}

						global::System.DateTime From {set;}

						global::System.DateTime? Through {set;}

		}
		public interface Organisation  : AccessControlledObject, Localised, Deletable 
		{
						global::System.String Name {set;}

						Person CurrentEmployees {set;}

						Person FormerEmployees {set;}

		}
		public interface Person  : Deletable, User, UniquelyIdentifiable 
		{
						Media Picture {set;}

						global::System.String FirstName {set;}

						global::System.String LastName {set;}

						global::System.String MiddleName {set;}

		}
		public interface Settings  : Object 
		{
						Counter Counter {set;}

						global::System.String Setting {set;}

		}
		public interface Singleton  : AccessControlledObject 
		{
						SecurityToken AdministratorSecurityToken {set;}

						Settings Settings {set;}

						Locale DefaultLocale {set;}

						Locale AdditionalLocales {set;}

						User Guest {set;}

						SecurityToken InitialSecurityToken {set;}

						SecurityToken DefaultSecurityToken {set;}

						AccessControl CreatorsAccessControl {set;}

						AccessControl GuestAccessControl {set;}

						AccessControl AdministratorsAccessControl {set;}

						Media LogoImage {set;}

		}
		public interface Counter  : UniquelyIdentifiable 
		{
						global::System.Int32 Value {set;}

		}
		public interface Media  : UniquelyIdentifiable, AccessControlledObject, Deletable 
		{
						global::System.Guid? Revision {set;}

						MediaContent MediaContent {set;}

						global::System.Byte[] InData {set;}

						global::System.String InDataUri {set;}

						global::System.String FileName {set;}

						global::System.String Type {set;}

		}
		public interface MediaContent  : AccessControlledObject, Deletable 
		{
						global::System.String Type {set;}

						global::System.Byte[] Data {set;}

		}
		public interface Template  : UniquelyIdentifiable, AccessControlledObject, Deletable 
		{
						TemplateType TemplateType {set;}

						Media Media {set;}

						global::System.String Arguments {set;}

		}
		public interface TemplateType  : Enumeration, Deletable 
		{
		}
		public interface PreparedExtent  : UniquelyIdentifiable, Deletable 
		{
						global::System.String Name {set;}

						global::System.String Description {set;}

						global::System.String Content {set;}

		}
		public interface PreparedFetch  : UniquelyIdentifiable, Deletable 
		{
						global::System.String Name {set;}

						global::System.String Description {set;}

						global::System.String Content {set;}

		}
		public interface Country  : AccessControlledObject 
		{
						Currency Currency {set;}

						global::System.String IsoCode {set;}

						global::System.String Name {set;}

						LocalisedText LocalisedNames {set;}

		}
		public interface Currency  : Enumeration 
		{
						global::System.String IsoCode {set;}

		}
		public interface Language  : AccessControlledObject 
		{
						global::System.String IsoCode {set;}

						global::System.String Name {set;}

						LocalisedText LocalisedNames {set;}

						global::System.String NativeName {set;}

		}
		public interface Locale  : AccessControlledObject 
		{
						global::System.String Name {set;}

						Language Language {set;}

						Country Country {set;}

		}
		public interface LocalisedText  : AccessControlledObject, Localised, Deletable 
		{
						global::System.String Text {set;}

		}
		public interface AccessControl  : Cachable, Deletable, AccessControlledObject 
		{
						UserGroup SubjectGroups {set;}

						User Subjects {set;}

						Role Role {set;}

						Permission EffectivePermissions {set;}

						User EffectiveUsers {set;}

		}
		public interface Login  : Deletable 
		{
						global::System.String Key {set;}

						global::System.String Provider {set;}

						User User {set;}

		}
		public interface Permission  : Deletable, AccessControlledObject 
		{
						global::System.Guid OperandTypePointer {set;}

						global::System.Guid ConcreteClassPointer {set;}

						global::System.Int32 OperationEnum {set;}

		}
		public interface Role  : AccessControlledObject, UniquelyIdentifiable 
		{
						Permission Permissions {set;}

						global::System.String Name {set;}

		}
		public interface SecurityToken  : Deletable 
		{
						AccessControl AccessControls {set;}

		}
		public interface AutomatedAgent  : User 
		{
						global::System.String Name {set;}

						global::System.String Description {set;}

		}
		public interface EmailMessage  : Object 
		{
						global::System.DateTime DateCreated {set;}

						global::System.DateTime? DateSending {set;}

						global::System.DateTime? DateSent {set;}

						User Sender {set;}

						User Recipients {set;}

						global::System.String RecipientEmailAddress {set;}

						global::System.String Subject {set;}

						global::System.String Body {set;}

		}
		public interface Notification  : AccessControlledObject 
		{
						UniquelyIdentifiable Target {set;}

						global::System.Boolean Confirmed {set;}

						global::System.String Title {set;}

						global::System.String Description {set;}

						global::System.DateTime DateCreated {set;}

		}
		public interface NotificationList  : AccessControlledObject, Deletable 
		{
						Notification Notifications {set;}

						Notification UnconfirmedNotifications {set;}

						Notification ConfirmedNotifications {set;}

		}
		public interface TaskAssignment  : AccessControlledObject, Deletable 
		{
						User User {set;}

						Notification Notification {set;}

						Task Task {set;}

		}
		public interface TaskList  : Deletable 
		{
						TaskAssignment TaskAssignments {set;}

						TaskAssignment OpenTaskAssignments {set;}

						global::System.Int32? Count {set;}

		}
		public interface UserGroup  : UniquelyIdentifiable, AccessControlledObject 
		{
						User Members {set;}

						global::System.String Name {set;}

		}
}