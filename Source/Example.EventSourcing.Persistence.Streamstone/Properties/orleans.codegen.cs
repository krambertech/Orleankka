//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34209
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------
#if !EXCLUDE_CODEGEN
#pragma warning disable 162
#pragma warning disable 219
#pragma warning disable 414
#pragma warning disable 649
#pragma warning disable 693
#pragma warning disable 1591
#pragma warning disable 1998

namespace Example.EventSourcing.Persistence.StreamstoneSerializers
{
    using System;
    using System.Collections.Generic;
    using System.Reflection;
    using Orleans.Serialization;
    using Example;
    using System.Collections;
    using System.Runtime.InteropServices;
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.8.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.RegisterSerializerAttribute()]
    internal class Example_CreateInventoryItemSerialization
    {
        
        private static System.Reflection.FieldInfo fieldInfo1;
        
        static Example_CreateInventoryItemSerialization()
        {
            Register();
        }
        
        public static object DeepCopier(object original)
        {
            Example.CreateInventoryItem input = ((Example.CreateInventoryItem)(original));
            Example.CreateInventoryItem result = ((Example.CreateInventoryItem)(System.Runtime.Serialization.FormatterServices.GetUninitializedObject(typeof(Example.CreateInventoryItem))));
            Orleans.Serialization.SerializationContext.Current.RecordObject(original, result);
            object objResult = ((object)(result));
            object temp1 = input.Name;
            fieldInfo1.SetValue(objResult, temp1);
            return objResult;
        }
        
        public static void Serializer(object untypedInput, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            Example.CreateInventoryItem input = ((Example.CreateInventoryItem)(untypedInput));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Name, stream, typeof(string));
        }
        
        public static object Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            Example.CreateInventoryItem result = ((Example.CreateInventoryItem)(System.Runtime.Serialization.FormatterServices.GetUninitializedObject(typeof(Example.CreateInventoryItem))));
            object objResult = ((object)(result));
            object temp1 = ((string)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(string), stream)));
            fieldInfo1.SetValue(objResult, temp1);
            return objResult;
        }
        
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.Register(typeof(Example.CreateInventoryItem), DeepCopier, Serializer, Deserializer);
            fieldInfo1 = typeof(Example.CreateInventoryItem).GetField("Name", (System.Reflection.BindingFlags.Instance 
                            | (System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic)));
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.8.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.RegisterSerializerAttribute()]
    internal class Example_CheckInInventoryItemSerialization
    {
        
        private static System.Reflection.FieldInfo fieldInfo1;
        
        static Example_CheckInInventoryItemSerialization()
        {
            Register();
        }
        
        public static object DeepCopier(object original)
        {
            Example.CheckInInventoryItem input = ((Example.CheckInInventoryItem)(original));
            Example.CheckInInventoryItem result = ((Example.CheckInInventoryItem)(System.Runtime.Serialization.FormatterServices.GetUninitializedObject(typeof(Example.CheckInInventoryItem))));
            Orleans.Serialization.SerializationContext.Current.RecordObject(original, result);
            object objResult = ((object)(result));
            object temp1 = input.Quantity;
            fieldInfo1.SetValue(objResult, temp1);
            return objResult;
        }
        
        public static void Serializer(object untypedInput, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            Example.CheckInInventoryItem input = ((Example.CheckInInventoryItem)(untypedInput));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Quantity, stream, typeof(int));
        }
        
        public static object Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            Example.CheckInInventoryItem result = ((Example.CheckInInventoryItem)(System.Runtime.Serialization.FormatterServices.GetUninitializedObject(typeof(Example.CheckInInventoryItem))));
            object objResult = ((object)(result));
            object temp1 = ((int)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(int), stream)));
            fieldInfo1.SetValue(objResult, temp1);
            return objResult;
        }
        
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.Register(typeof(Example.CheckInInventoryItem), DeepCopier, Serializer, Deserializer);
            fieldInfo1 = typeof(Example.CheckInInventoryItem).GetField("Quantity", (System.Reflection.BindingFlags.Instance 
                            | (System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic)));
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.8.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.RegisterSerializerAttribute()]
    internal class Example_CheckOutInventoryItemSerialization
    {
        
        private static System.Reflection.FieldInfo fieldInfo1;
        
        static Example_CheckOutInventoryItemSerialization()
        {
            Register();
        }
        
        public static object DeepCopier(object original)
        {
            Example.CheckOutInventoryItem input = ((Example.CheckOutInventoryItem)(original));
            Example.CheckOutInventoryItem result = ((Example.CheckOutInventoryItem)(System.Runtime.Serialization.FormatterServices.GetUninitializedObject(typeof(Example.CheckOutInventoryItem))));
            Orleans.Serialization.SerializationContext.Current.RecordObject(original, result);
            object objResult = ((object)(result));
            object temp1 = input.Quantity;
            fieldInfo1.SetValue(objResult, temp1);
            return objResult;
        }
        
        public static void Serializer(object untypedInput, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            Example.CheckOutInventoryItem input = ((Example.CheckOutInventoryItem)(untypedInput));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Quantity, stream, typeof(int));
        }
        
        public static object Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            Example.CheckOutInventoryItem result = ((Example.CheckOutInventoryItem)(System.Runtime.Serialization.FormatterServices.GetUninitializedObject(typeof(Example.CheckOutInventoryItem))));
            object objResult = ((object)(result));
            object temp1 = ((int)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(int), stream)));
            fieldInfo1.SetValue(objResult, temp1);
            return objResult;
        }
        
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.Register(typeof(Example.CheckOutInventoryItem), DeepCopier, Serializer, Deserializer);
            fieldInfo1 = typeof(Example.CheckOutInventoryItem).GetField("Quantity", (System.Reflection.BindingFlags.Instance 
                            | (System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic)));
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.8.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.RegisterSerializerAttribute()]
    internal class Example_RenameInventoryItemSerialization
    {
        
        private static System.Reflection.FieldInfo fieldInfo1;
        
        static Example_RenameInventoryItemSerialization()
        {
            Register();
        }
        
        public static object DeepCopier(object original)
        {
            Example.RenameInventoryItem input = ((Example.RenameInventoryItem)(original));
            Example.RenameInventoryItem result = ((Example.RenameInventoryItem)(System.Runtime.Serialization.FormatterServices.GetUninitializedObject(typeof(Example.RenameInventoryItem))));
            Orleans.Serialization.SerializationContext.Current.RecordObject(original, result);
            object objResult = ((object)(result));
            object temp1 = input.NewName;
            fieldInfo1.SetValue(objResult, temp1);
            return objResult;
        }
        
        public static void Serializer(object untypedInput, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            Example.RenameInventoryItem input = ((Example.RenameInventoryItem)(untypedInput));
            Orleans.Serialization.SerializationManager.SerializeInner(input.NewName, stream, typeof(string));
        }
        
        public static object Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            Example.RenameInventoryItem result = ((Example.RenameInventoryItem)(System.Runtime.Serialization.FormatterServices.GetUninitializedObject(typeof(Example.RenameInventoryItem))));
            object objResult = ((object)(result));
            object temp1 = ((string)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(string), stream)));
            fieldInfo1.SetValue(objResult, temp1);
            return objResult;
        }
        
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.Register(typeof(Example.RenameInventoryItem), DeepCopier, Serializer, Deserializer);
            fieldInfo1 = typeof(Example.RenameInventoryItem).GetField("NewName", (System.Reflection.BindingFlags.Instance 
                            | (System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic)));
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.8.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.RegisterSerializerAttribute()]
    internal class Example_DeactivateInventoryItemSerialization
    {
        
        static Example_DeactivateInventoryItemSerialization()
        {
            Register();
        }
        
        public static object DeepCopier(object original)
        {
            Example.DeactivateInventoryItem input = ((Example.DeactivateInventoryItem)(original));
            Example.DeactivateInventoryItem result = new Example.DeactivateInventoryItem();
            Orleans.Serialization.SerializationContext.Current.RecordObject(original, result);
            return result;
        }
        
        public static void Serializer(object untypedInput, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            Example.DeactivateInventoryItem input = ((Example.DeactivateInventoryItem)(untypedInput));
        }
        
        public static object Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            Example.DeactivateInventoryItem result = new Example.DeactivateInventoryItem();
            return result;
        }
        
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.Register(typeof(Example.DeactivateInventoryItem), DeepCopier, Serializer, Deserializer);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.8.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.RegisterSerializerAttribute()]
    internal class Example_GetInventoryItemDetailsSerialization
    {
        
        static Example_GetInventoryItemDetailsSerialization()
        {
            Register();
        }
        
        public static object DeepCopier(object original)
        {
            Example.GetInventoryItemDetails input = ((Example.GetInventoryItemDetails)(original));
            Example.GetInventoryItemDetails result = new Example.GetInventoryItemDetails();
            Orleans.Serialization.SerializationContext.Current.RecordObject(original, result);
            return result;
        }
        
        public static void Serializer(object untypedInput, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            Example.GetInventoryItemDetails input = ((Example.GetInventoryItemDetails)(untypedInput));
        }
        
        public static object Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            Example.GetInventoryItemDetails result = new Example.GetInventoryItemDetails();
            return result;
        }
        
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.Register(typeof(Example.GetInventoryItemDetails), DeepCopier, Serializer, Deserializer);
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.8.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.RegisterSerializerAttribute()]
    internal class Example_InventoryItemDetailsSerialization
    {
        
        private static System.Reflection.FieldInfo fieldInfo1;
        
        private static System.Reflection.FieldInfo fieldInfo2;
        
        private static System.Reflection.FieldInfo fieldInfo3;
        
        static Example_InventoryItemDetailsSerialization()
        {
            Register();
        }
        
        public static object DeepCopier(object original)
        {
            Example.InventoryItemDetails input = ((Example.InventoryItemDetails)(original));
            Example.InventoryItemDetails result = ((Example.InventoryItemDetails)(System.Runtime.Serialization.FormatterServices.GetUninitializedObject(typeof(Example.InventoryItemDetails))));
            Orleans.Serialization.SerializationContext.Current.RecordObject(original, result);
            object objResult = ((object)(result));
            object temp1 = input.Active;
            fieldInfo1.SetValue(objResult, temp1);
            object temp2 = input.Name;
            fieldInfo2.SetValue(objResult, temp2);
            object temp3 = input.Total;
            fieldInfo3.SetValue(objResult, temp3);
            return objResult;
        }
        
        public static void Serializer(object untypedInput, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            Example.InventoryItemDetails input = ((Example.InventoryItemDetails)(untypedInput));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Active, stream, typeof(bool));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Name, stream, typeof(string));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Total, stream, typeof(int));
        }
        
        public static object Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            Example.InventoryItemDetails result = ((Example.InventoryItemDetails)(System.Runtime.Serialization.FormatterServices.GetUninitializedObject(typeof(Example.InventoryItemDetails))));
            object objResult = ((object)(result));
            object temp1 = ((bool)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(bool), stream)));
            fieldInfo1.SetValue(objResult, temp1);
            object temp2 = ((string)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(string), stream)));
            fieldInfo2.SetValue(objResult, temp2);
            object temp3 = ((int)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(int), stream)));
            fieldInfo3.SetValue(objResult, temp3);
            return objResult;
        }
        
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.Register(typeof(Example.InventoryItemDetails), DeepCopier, Serializer, Deserializer);
            fieldInfo1 = typeof(Example.InventoryItemDetails).GetField("Active", (System.Reflection.BindingFlags.Instance 
                            | (System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic)));
            fieldInfo2 = typeof(Example.InventoryItemDetails).GetField("Name", (System.Reflection.BindingFlags.Instance 
                            | (System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic)));
            fieldInfo3 = typeof(Example.InventoryItemDetails).GetField("Total", (System.Reflection.BindingFlags.Instance 
                            | (System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic)));
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.8.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.RegisterSerializerAttribute()]
    internal class Example_InventoryItemCreatedSerialization
    {
        
        private static System.Reflection.FieldInfo fieldInfo1;
        
        static Example_InventoryItemCreatedSerialization()
        {
            Register();
        }
        
        public static object DeepCopier(object original)
        {
            Example.InventoryItemCreated input = ((Example.InventoryItemCreated)(original));
            Example.InventoryItemCreated result = ((Example.InventoryItemCreated)(System.Runtime.Serialization.FormatterServices.GetUninitializedObject(typeof(Example.InventoryItemCreated))));
            Orleans.Serialization.SerializationContext.Current.RecordObject(original, result);
            object objResult = ((object)(result));
            object temp1 = input.Name;
            fieldInfo1.SetValue(objResult, temp1);
            return objResult;
        }
        
        public static void Serializer(object untypedInput, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            Example.InventoryItemCreated input = ((Example.InventoryItemCreated)(untypedInput));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Name, stream, typeof(string));
        }
        
        public static object Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            Example.InventoryItemCreated result = ((Example.InventoryItemCreated)(System.Runtime.Serialization.FormatterServices.GetUninitializedObject(typeof(Example.InventoryItemCreated))));
            object objResult = ((object)(result));
            object temp1 = ((string)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(string), stream)));
            fieldInfo1.SetValue(objResult, temp1);
            return objResult;
        }
        
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.Register(typeof(Example.InventoryItemCreated), DeepCopier, Serializer, Deserializer);
            fieldInfo1 = typeof(Example.InventoryItemCreated).GetField("Name", (System.Reflection.BindingFlags.Instance 
                            | (System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic)));
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.8.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.RegisterSerializerAttribute()]
    internal class Example_InventoryItemCheckedInSerialization
    {
        
        private static System.Reflection.FieldInfo fieldInfo1;
        
        static Example_InventoryItemCheckedInSerialization()
        {
            Register();
        }
        
        public static object DeepCopier(object original)
        {
            Example.InventoryItemCheckedIn input = ((Example.InventoryItemCheckedIn)(original));
            Example.InventoryItemCheckedIn result = ((Example.InventoryItemCheckedIn)(System.Runtime.Serialization.FormatterServices.GetUninitializedObject(typeof(Example.InventoryItemCheckedIn))));
            Orleans.Serialization.SerializationContext.Current.RecordObject(original, result);
            object objResult = ((object)(result));
            object temp1 = input.Quantity;
            fieldInfo1.SetValue(objResult, temp1);
            return objResult;
        }
        
        public static void Serializer(object untypedInput, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            Example.InventoryItemCheckedIn input = ((Example.InventoryItemCheckedIn)(untypedInput));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Quantity, stream, typeof(int));
        }
        
        public static object Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            Example.InventoryItemCheckedIn result = ((Example.InventoryItemCheckedIn)(System.Runtime.Serialization.FormatterServices.GetUninitializedObject(typeof(Example.InventoryItemCheckedIn))));
            object objResult = ((object)(result));
            object temp1 = ((int)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(int), stream)));
            fieldInfo1.SetValue(objResult, temp1);
            return objResult;
        }
        
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.Register(typeof(Example.InventoryItemCheckedIn), DeepCopier, Serializer, Deserializer);
            fieldInfo1 = typeof(Example.InventoryItemCheckedIn).GetField("Quantity", (System.Reflection.BindingFlags.Instance 
                            | (System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic)));
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.8.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.RegisterSerializerAttribute()]
    internal class Example_InventoryItemCheckedOutSerialization
    {
        
        private static System.Reflection.FieldInfo fieldInfo1;
        
        static Example_InventoryItemCheckedOutSerialization()
        {
            Register();
        }
        
        public static object DeepCopier(object original)
        {
            Example.InventoryItemCheckedOut input = ((Example.InventoryItemCheckedOut)(original));
            Example.InventoryItemCheckedOut result = ((Example.InventoryItemCheckedOut)(System.Runtime.Serialization.FormatterServices.GetUninitializedObject(typeof(Example.InventoryItemCheckedOut))));
            Orleans.Serialization.SerializationContext.Current.RecordObject(original, result);
            object objResult = ((object)(result));
            object temp1 = input.Quantity;
            fieldInfo1.SetValue(objResult, temp1);
            return objResult;
        }
        
        public static void Serializer(object untypedInput, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            Example.InventoryItemCheckedOut input = ((Example.InventoryItemCheckedOut)(untypedInput));
            Orleans.Serialization.SerializationManager.SerializeInner(input.Quantity, stream, typeof(int));
        }
        
        public static object Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            Example.InventoryItemCheckedOut result = ((Example.InventoryItemCheckedOut)(System.Runtime.Serialization.FormatterServices.GetUninitializedObject(typeof(Example.InventoryItemCheckedOut))));
            object objResult = ((object)(result));
            object temp1 = ((int)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(int), stream)));
            fieldInfo1.SetValue(objResult, temp1);
            return objResult;
        }
        
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.Register(typeof(Example.InventoryItemCheckedOut), DeepCopier, Serializer, Deserializer);
            fieldInfo1 = typeof(Example.InventoryItemCheckedOut).GetField("Quantity", (System.Reflection.BindingFlags.Instance 
                            | (System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic)));
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.8.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.RegisterSerializerAttribute()]
    internal class Example_InventoryItemRenamedSerialization
    {
        
        private static System.Reflection.FieldInfo fieldInfo1;
        
        private static System.Reflection.FieldInfo fieldInfo2;
        
        static Example_InventoryItemRenamedSerialization()
        {
            Register();
        }
        
        public static object DeepCopier(object original)
        {
            Example.InventoryItemRenamed input = ((Example.InventoryItemRenamed)(original));
            Example.InventoryItemRenamed result = ((Example.InventoryItemRenamed)(System.Runtime.Serialization.FormatterServices.GetUninitializedObject(typeof(Example.InventoryItemRenamed))));
            Orleans.Serialization.SerializationContext.Current.RecordObject(original, result);
            object objResult = ((object)(result));
            object temp1 = input.NewName;
            fieldInfo1.SetValue(objResult, temp1);
            object temp2 = input.OldName;
            fieldInfo2.SetValue(objResult, temp2);
            return objResult;
        }
        
        public static void Serializer(object untypedInput, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            Example.InventoryItemRenamed input = ((Example.InventoryItemRenamed)(untypedInput));
            Orleans.Serialization.SerializationManager.SerializeInner(input.NewName, stream, typeof(string));
            Orleans.Serialization.SerializationManager.SerializeInner(input.OldName, stream, typeof(string));
        }
        
        public static object Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            Example.InventoryItemRenamed result = ((Example.InventoryItemRenamed)(System.Runtime.Serialization.FormatterServices.GetUninitializedObject(typeof(Example.InventoryItemRenamed))));
            object objResult = ((object)(result));
            object temp1 = ((string)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(string), stream)));
            fieldInfo1.SetValue(objResult, temp1);
            object temp2 = ((string)(Orleans.Serialization.SerializationManager.DeserializeInner(typeof(string), stream)));
            fieldInfo2.SetValue(objResult, temp2);
            return objResult;
        }
        
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.Register(typeof(Example.InventoryItemRenamed), DeepCopier, Serializer, Deserializer);
            fieldInfo1 = typeof(Example.InventoryItemRenamed).GetField("NewName", (System.Reflection.BindingFlags.Instance 
                            | (System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic)));
            fieldInfo2 = typeof(Example.InventoryItemRenamed).GetField("OldName", (System.Reflection.BindingFlags.Instance 
                            | (System.Reflection.BindingFlags.Public | System.Reflection.BindingFlags.NonPublic)));
        }
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("Orleans-CodeGenerator", "1.0.8.0")]
    [System.Diagnostics.CodeAnalysis.ExcludeFromCodeCoverageAttribute()]
    [global::Orleans.CodeGeneration.RegisterSerializerAttribute()]
    internal class Example_InventoryItemDeactivatedSerialization
    {
        
        static Example_InventoryItemDeactivatedSerialization()
        {
            Register();
        }
        
        public static object DeepCopier(object original)
        {
            Example.InventoryItemDeactivated input = ((Example.InventoryItemDeactivated)(original));
            Example.InventoryItemDeactivated result = new Example.InventoryItemDeactivated();
            Orleans.Serialization.SerializationContext.Current.RecordObject(original, result);
            return result;
        }
        
        public static void Serializer(object untypedInput, Orleans.Serialization.BinaryTokenStreamWriter stream, System.Type expected)
        {
            Example.InventoryItemDeactivated input = ((Example.InventoryItemDeactivated)(untypedInput));
        }
        
        public static object Deserializer(System.Type expected, global::Orleans.Serialization.BinaryTokenStreamReader stream)
        {
            Example.InventoryItemDeactivated result = new Example.InventoryItemDeactivated();
            return result;
        }
        
        public static void Register()
        {
            global::Orleans.Serialization.SerializationManager.Register(typeof(Example.InventoryItemDeactivated), DeepCopier, Serializer, Deserializer);
        }
    }
}
#pragma warning restore 162
#pragma warning restore 219
#pragma warning restore 414
#pragma warning restore 649
#pragma warning restore 693
#pragma warning restore 1591
#pragma warning restore 1998
#endif
