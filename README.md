# Bit Collections

Bit Collections for Unity is all about saving as much RAM and/or network bandwidth as possible, by providing array value types of single bits, aswell as array value types of signed- and unsigned integers with a given number of bits.

Since using less RAM usually comes at the cost of taking more time (CPU), this library uses SIMD instructions as much possible, resulting in the following dependencies:

- Unity 2020.2.0f (C# 8 => unmanaged constructed types)
- Unity.Mathematics
- Unity.Burst
- Unity.Collections (A native bit-array and generic, native "bit-number" arrays are defined)
- Unity.Jobs (Mainly for de-allocating the mentioned arrays on a worker thread)
- [MaxMath](https://github.com/MrUnbelievable92/MaxMath) (my SIMD library supplementary to Unity.Mathematics)
- [C Sharp Dev Tools](https://github.com/MrUnbelievable92/C-Sharp-Dev-Tools) (Conditionally compiled runtime-checks)






Bit Arrays:

![alt text](https://i.imgur.com/NvwjrnH.png)




Generic Bit Arrays:

![alt text](https://i.imgur.com/mvWMvll.png)




Number Arrays:

![alt text](https://i.imgur.com/ViNwApd.png)




Bit-Number Min- and Max Values:

![alt text](https://i.imgur.com/snM6KaI.png)




Additionally, 3- 5- 6- and 7-Byte Numbers are defined:

![alt text](https://i.imgur.com/Gl8eguA.png)




... Which Work (almost) Just Like Normal Integers:

![alt text](https://i.imgur.com/KD670VA.png)


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

