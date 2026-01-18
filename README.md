# Bit Collections

Bit Collections for Unity is all about saving as much RAM and/or network bandwidth as possible with a minimal performance trade-off, by providing stack and heap allocated bits, as well as stack and heap allocated signed and unsigned integers with an arbitrary number of bits between 1 and 63.

The compression applied is geared towards performance first, but can and should also be used before applying advanced compression algorithms on your data. 

This package has the following dependencies:

- Unity.Mathematics
- Unity.Burst
- Unity.Collections
- Unity.Jobs
- [MaxMath](https://github.com/MrUnbelievable92/MaxMath)
- [C Sharp Dev Tools](https://github.com/MrUnbelievable92/C-Sharp-Dev-Tools)
- [SIMD Algorithms](https://github.com/MrUnbelievable92/SIMD-Algorithms)

# Functionality

## Value Types

### BitInt
The most fundamental building block in this library is the interface `BitInt`. It defines how many bits an integer has and whether or not it is signed.
All integers between 1 and 63 bits are defined as types, named `(U)Int[n]`, except for `Bit`, which is only available as an unsigned integer. Most of the time, these types are only used as generic type parameters; they should not be instantiated.
![alt text](https://i.imgur.com/JkW8vfM.png)

### Byte Ints	
Among all `BitInt`s are all integers consisting of a multiple of eight bits, which are implemented as fully usable types with the entire standard C# API for integers, and they integrate with all C# integer and floating point types as well as `Unity.Mathematics` and `MaxMath` types such as vectors and `MaxMath.UInt128` or `MaxMath.quadruple`.
![alt text](https://i.imgur.com/VBCXsgk.png)

Now that we have all integers taking up all of 1 to 8 bytes exactly, we define the following three groups of value types:

### Bit Arrays

`bit8`, `bit16`, `bit24`, `bit32`, `bit40`, `bit48`, `bit56`, `bit64`, and a `bits<T>` struct hold packed bits that can be read out as `bool`s and written individually with the `[]` index operator. 
These also have boolean logic operators, such as the unary `!` - and the binary `&`, `|` and `^` operators, as well as comparison operators. 
There is also a collection of useful member methods available, such as `IndexOfFirst`, `RotateLeft`, `Swap`, `TestAny` and many more.
![alt text](https://i.imgur.com/ZcDx9mS.png)

### Fixed Size Vectors

We look at all `BitInts` and determine if a multiple of them would fill up the entirety of 1, 2, 3, [...] or 8 bytes and if so, define a struct that holds them, naming it `(U)Int[bits]x[numValues]`. This defines all possible of the following value type fixed-size arrays both in signed an unsigned form:
![alt text](https://i.imgur.com/LEZ4LF0.png)

These vectors receive special treatment; apart from the expected `[]` index operator, all bitwise, arithmetic and comparison operators are implemented for them, utilizing [SWAR](https://en.wikipedia.org/wiki/SWAR) and/or [SIMD](https://en.wikipedia.org/wiki/Single_instruction,_multiple_data) operations, whichever yields higher performance.
Additionally, these vectors are convertible between each other, as well as convertible to and from `Unity.Mathematics` and `MaxMath` vector types, provided that the numbers of elements are equal.
![alt text](https://i.imgur.com/nop8Abl.png)

### Custom Bitfields

For each whole byte between 1 and 8 (inclusive), we can also use custom bit layouts. These always have generic `BitInt` type parameters; a `BitField24`, for instance, is implemented as a type with anywhere between 2 and 23 `BitInt` type parameters. 
Currently, these can only be manipulated and read via their `Field[n]` getter and setter properties.
![alt text](https://i.imgur.com/NCrN0m0.png)
	
	
	
## Heap Allocated Types

Small, fixed-size containers are already powerful and can be allocated on the heap, too, but what we also really want are dynamically sized containers that waste no space, while keeping performance as high as possible.
The following containers are true Native Containers and integrate into `Unity.Collections` and the job system fully, guaranteeing thread-safety, leak detection, initialization etc.

### NativeBitArray

This container behaves exactly like a typical C# array, just for contiguous bits in memory. 
It encapsulates the entire `Unity.Collections` API available to arrays, as well as other powerful algorithms as member methods.
NOTE: `Unity.Collections` already defines such a container with the exact same name. It is advised to use `BitCollections.NativeBitArray`, as the latter wastes less space and is more performant.

### NativeBitList

This container behaves exactly like a typical C# list, meaning it is a resizable array, just for contiguous bits in memory. 
It encapsulates the entire `Unity.Collections` API available to lists, as well as other powerful algorithms as member methods.

### NativeBitIntArray<T>

This container behaves exactly like a typical C# array, just that it holds contiguous `BitInt`s in memory. For that it requires the type parameter to be a `BitInt`.
Unlike the fixed-size vectors, this container can store any `BitInt`. 
Its `[]` index operator expects `long`s as values and always returns a `long`, since this is the only native data type to hold anywhere between 1 and 63 bits as either signed or unsigned values.
It encapsulates the entire `Unity.Collections` API available to arrays, as well as other powerful algorithms as member methods.
![alt text](https://i.imgur.com/Z7367gh.png)

### NativeBitIntList<T>

This container behaves exactly like a typical C# list, meaning it is a resizable array, just that it holds contiguous `BitInt`s in memory. For that it requires the type parameter to be a `BitInt`.
It encapsulates the entire `Unity.Collections` API available to lists, as well as other powerful algorithms as member methods.
Other than that, it behaves just like `NativeBitIntArray<T>`.

### Advanced Usage

These four containers have optimized algorithms as member methods that avoid reading out/writing values individually. Where appropriate, they use `SIMDAlgorithms`' `Comparison` enum for advanced algorithms:
![alt text](https://i.imgur.com/sUYy9V0.png)
While specialized algorithms cover many common operations, not everything can be generalized. To avoid iterating over each packed integer individually, these containers define optimized `T LoadVector<T>(int index)` and `void StoreVector<T>(T vector, int index)` member methods, which are powerful tools for SIMD processing of data in bulk:
![alt text](https://i.imgur.com/FFbFiPd.png)
You can load and store any integer and boolean vector type defined in `Unity.Mathematics`, `MaxMath` and fixed-size `BitInt` vectors in this library, including bit array value types.
In addition, `Unity.Collections` `NativeArray<T>`, `NativeList<T>` and `NativeSlice<T>` containers that hold byte-sized `BitInts` (`UInt24`, `Int56` etc.) have had extension methods implemented for loading and storing vectors in the same way:
![alt text](https://i.imgur.com/sy1M6ke.png)
Lastly, all list-type methods that copy data in bulk from another array/list (`AddRange`, `InsertRange`, `CopyFrom` etc.) that allow copying to and from these four containers have been implemented, including `NativeBitInt` containers with differing `BitInt` type parameters between them, either directly or as extension methods for `NativeArray/List/Slice<[ANY_INTEGER_TYPE]>`:
![alt text](https://i.imgur.com/3086WqN.png)

	
	
## Addendum

### Design Philosophy

There are faster bitpacking algorithms out there - some of them rely entirely on SIMD processing in bulk.
Unfortunately, they compromise usability; they are focused on fast compression and decompression, not frequent reading and modification of arbitrary data.
A particularly fast library needs to load 128 n-bit integers just to read out a single value, and needs to store 128 n-bit integer chunks, accordingly. This wastes a ton of memory bandwidth (when not iterating over every integer) and space, which kind of defeats the purpose of bitpacking.
This library, on the other hand, focuses on:
- Usability. Abstracting away all 126 possible implementations behind one data structure/type (plus a specialized bit array type) with the aid of a generic type constraint has inherent value. Using familiar array and list semantics increases comfort of usage further. Additionally, the integration of `Unity.Mathematics` and `MaxMath`, as well as standard C# types into the API makes programming against it seamless.
- Specialized Usage. While the native, heap allocated containers solve the most pressing issue of having to store a lot of data in a manner that is both space- and time-efficient, fixed-size value type arrays and custom bitfields provide the user with meaningful options. If an entity in your program holds, for example, four 2-bit integers (think of an enum with the values 'None', 'Poor', 'Mediocre', and 'Good'), it may be better to store them in a `UInt2x4` in an [SoA](https://en.wikipedia.org/wiki/AoS_and_SoA) manner, likely benefiting from [auto-vectorization](https://en.wikipedia.org/wiki/Automatic_vectorization).
- Space - more critical than raw performance. The data structures provided only use exactly as much space as is absolutely necessary. This ensures optimal bandwidth and storage utilization even for millions of elements.
- Performance. While not being as fast as pure compression and decompression algorithms, frequent reading and/or modification of smaller pieces of data is fast. Furthermore, algorithms that need to iterate over all of the data are abstracted away as member methods and are optimized. For the bit-twiddlers among you, custom low-level algorithms are easy to implement via the `container.GetUnsafe(ReadOnly)Ptr` and `container.SizeInBytes` API provided.
- Correctness. Over one third of the codebase consists of unit tests. Despite the inherent complexity of testing arbitrary (and sometimes mixed) bit widths, signedness, and SIMD/SWAR code paths, all types/containers are extensively validated, making the library safe to consider production-ready.



### Upcoming, WIP and functionality under consideration 

- XML documentation for each method and type is a priority.
- Hash Maps with either key or value (or both) being a `BitInt` are next on the to-do-list and by far the most important missing feature.
- Not everything is highly optimized. There are almost 64 * 64 = 4096 combinations between possible pairs of `BitInts`; combined with the fact that some algorithms don't have a generalized solution (especially when it comes to vectorization), this requires hand-optimized code.
If you require a particular operation to be optimized (even if it is only for a very specific `BitInt`), [please open an issue](https://github.com/MrUnbelievable92/Bit-Collections/issues/new).
- Based on `MaxMath.UInt128`, fixed-size bitfields between 9 and 16 bytes (inclusive) are under consideration, due to native double register shift instructions existing
- Custom floats (sign bit - yes or no? how many mantissa bits? how many exponent bits?) are under consideration.
- Further requests are welcome. If you have something you need, [please open an issue](https://github.com/MrUnbelievable92/Bit-Collections/issues/new).


# How To Install This Library

Disclaimer: I firmly believe in open source - being able to copy/modify/understand other people's code is great :)
I also want people to be able to step through code with a debugger.
For these reasons I usually don't distribute DLLs.

- Download the package and unzip it into your "LocalPackages" folder, which is located at the root folder of your Unity project (where your "Assets" folder resides at).
- Start up Unity. Usually Unity detects new packages and will generate .meta files for you.
- In case that doesn't work, open up the package manager from within Unity and click on the '+' symbol at the upper left corner of the window, further clicking on "Add package from disk..." - "Add package from git URL" should also work.

![alt text](https://i.imgur.com/QcqF96e.png)

- Locate the library's "package.json" file
- DONE! 

# Donations

If this repository has been valuable to your projects and you'd like to support my work, consider making a donation.

[![donateBTC](https://github.com/MrUnbelievable92/Bit-Collections/blob/master/donate_bitcoin.png)](https://raw.githubusercontent.com/MrUnbelievable92/Bit-Collections/master/bitcoin_address.txt)
[![donatePP](https://github.com/MrUnbelievable92/Bit-Collections/blob/master/donate_paypal.png)](https://www.paypal.com/donate/?hosted_button_id=MARSK3E7WZP9C)
