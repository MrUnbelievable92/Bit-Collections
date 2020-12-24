# Bit-Collections

Bit Collections for Unity is all about saving as much RAM(-bandwidth) as possible, by providing array value types of single bits, aswell as array value types of signed- and unsigned numbers with a given number of bits.

Since using less RAM usually comes at the cost of more time (CPU), this library uses SIMD instructions as much possible, resulting in the following dependencies:

Unity 2020.2.0f (C# 8 => unmanaged constructed types)

Unity.Mathematics

Unity.Burst

Unity.Collections (A native bit-array and generic, native "bit-number" arrays are defined)

Unity.Jobs (Mainly for de-allocating the mentioned arrays on a worker thread)

MaxMath (my SIMD library supplementary to Unity.Mathematics)

C-Sharp-Dev-Tools (Conditionally compiled runtime-checks)






Bit Arrays:

![alt text](https://i.imgur.com/uStN0LF.png)




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
