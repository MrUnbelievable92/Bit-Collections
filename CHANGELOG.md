**Version 2.0 is a major rework of this library - please read the 'Changes' section carefully before you update and refer to the updated readme file for further information**

## Known Issues
- The internal descending bit copy function is unoptimized, affecting Heap allocated list type `Insert`, `InsertRange` and `InsertRangeWithBeginEnd`
- `NativeBitArray/List` `FindString` is unoptimized
- `NativeArray/List<ANY_INTEGER_TYPE>` extension methods `CopyFrom` and `InsertRange` with `NativeBitIntArray/List<T>` as the source are unoptimized
- `NativeBitIntArray/List<T>` methods `CopyFrom` and `InsertRange` with `NativeArray/List<ANY_INTEGER_TYPE>` or another `NativeBitIntArray/List<T>` as the source are unoptimized
- `NativeBitIntArray/List<T>` `Sort` with `T` being a `BitInt` with more than 14 bits is unoptimized

## Changes
API-BREAKING:
Two major changes have been made.
- `NativeBitNumberArray<TCollection, TElement>` has been renamed to `NativeBitIntArray`, always returns `long` values and requires `long`s as value parameters and now only has one generic type parameter, constrained to the newly added `BitInt` interface, allowing for anywhere between 1 to 63 bits per integer. Please refer to this libraries' updated readme for more information
- Non-heap-allocated containers like `bit8` have had their member methods changed to return a new instance if it would mutate data.

- Bumped "MaxMath" to version 2.9.9
- Bumped "Burst" to version 1.8.26
- This library now depends on [SIMD-Algorithms](https://github.com/MrUnbelievable92/SIMD-Algorithms)
- Bumped "Unity.Collections" dependency to version 1.2.4 and thus removed the dependency on "Unity.Jobs"

## Additions
- Added scoped registry support
- The newly added `BitInt` interface is now the fundamental primitive of this library, enabling anywhere from 1 (`Bit`) to `(U)Int63` bit integers
- Added value type bit arrays `bit24` `bit40` `bit48` `bit56`
- Added `BitField8`, `BitField16`, `BitField24`, `BitField32`, `BitField40`, `BitField48`, `BitField56` and `BitField64` with each of them having anywhere between 2 and [bits - 1] generic type parameters constrained to `BitInt`, allowing to use custom bit fields like `BitField32<UInt23, Int8, Bit>`
- Added type conversions for fixed-size `BitInt` fields (example: `Int2x4`) between all other fixed-size `BitInt` fields, as well as all `Unity.Mathematics` and `MaxMath` vectors
- Added arithmetic, bitwise and comparison operators for fixed-size `BitInt` fields
- Added `(U)Int24`, `(U)Int40`, `(U)Int48`, and `(U)Int56` conversion operators between `Unity.Mathematics` and `MaxMath` vectors and scalars
- Added static methods to `(U)Int24`, `(U)Int40`, `(U)Int48`, and `(U)Int56` that allow casting to wider types while performing fewer-, yet out-of-bounds memory loads, controlled by `SIMDAlgorithms.MemoryAccess`
- Added `NativeBitList`
- Added `NativeBitIntList`
- Added `NativeBitIntArray/List` methods `CopyFrom`, `AddRange` (List only), `InstertRange` (List only) taking `Unity.Collections.NativeArray/List/Slice<[ANY_INTEGER_TYPE]>` as the source
- Added BitCollections.NativeContainer property `SizeInBytes`
- Added BitCollections.NativeContainer algorithms `Sum` (with optional `System.TypeCode` result range), `SetReplicate`, `IndexOf` (with optional SIMD-Algorithms `Comparison`), `Contains` (with optional SIMD-Algorithms `Comparison`), `Count` (with optional SIMD-Algorithms `Comparison`), `CountBits`, `Sort`, `ArraysEqual`, all except `Sort` with overloads selecting a start index and the number of values to consider
- Added BitCollections.NativeContainer `StoreVector<T>` and `LoadVector<T>`, loading/storing any `BitCollections`, `Unity.Mathematics` and `MaxMath` vector
- Added `Unity.Collections.NativeList` extension method `Insert`
- Added `Unity.Collections.NativeArray/List/Slice<bool>` extension methods `CopyFrom`, `AddRange` (List only), `InstertRange` (List only) taking `NativeBitArray/List` as the source
- Added `Unity.Collections.NativeArray/List/Slice<bool>` extension methods `LoadVector<T>` and `StoreVector<T>`
- Added `Unity.Collections.NativeArray/List/Slice<[ANY_INTEGER_TYPE]>` extension methods `CopyFrom`, `AddRange` (List only), `InstertRange` (List only) taking `NativeBitIntArray/List` as the source
- Added `Unity.Collections.NativeArray/List/Slice<[ANY_INTEGER_TYPE]>` extension methods `LoadVector<T>` and `StoreVector<T>`
- Implemented the entire `Unity.Collections` API for `NativeBitArray/List` and `NativeBitIntArray/List`