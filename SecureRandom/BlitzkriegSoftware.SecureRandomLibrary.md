<a name='assembly'></a>
# BlitzkriegSoftware.SecureRandomLibrary

## Contents

- [SecureRandom](#T-BlitzkriegSoftware-SecureRandomLibrary-SecureRandom 'BlitzkriegSoftware.SecureRandomLibrary.SecureRandom')
  - [#ctor()](#M-BlitzkriegSoftware-SecureRandomLibrary-SecureRandom-#ctor 'BlitzkriegSoftware.SecureRandomLibrary.SecureRandom.#ctor')
  - [#ctor(seed)](#M-BlitzkriegSoftware-SecureRandomLibrary-SecureRandom-#ctor-System-Int32- 'BlitzkriegSoftware.SecureRandomLibrary.SecureRandom.#ctor(System.Int32)')
  - [Next()](#M-BlitzkriegSoftware-SecureRandomLibrary-SecureRandom-Next 'BlitzkriegSoftware.SecureRandomLibrary.SecureRandom.Next')
  - [Next(max)](#M-BlitzkriegSoftware-SecureRandomLibrary-SecureRandom-Next-System-Int32- 'BlitzkriegSoftware.SecureRandomLibrary.SecureRandom.Next(System.Int32)')
  - [Next(min,max)](#M-BlitzkriegSoftware-SecureRandomLibrary-SecureRandom-Next-System-Int32,System-Int32- 'BlitzkriegSoftware.SecureRandomLibrary.SecureRandom.Next(System.Int32,System.Int32)')
  - [NextBytes(buf)](#M-BlitzkriegSoftware-SecureRandomLibrary-SecureRandom-NextBytes-System-Byte[]- 'BlitzkriegSoftware.SecureRandomLibrary.SecureRandom.NextBytes(System.Byte[])')
  - [NextDouble()](#M-BlitzkriegSoftware-SecureRandomLibrary-SecureRandom-NextDouble 'BlitzkriegSoftware.SecureRandomLibrary.SecureRandom.NextDouble')

<a name='T-BlitzkriegSoftware-SecureRandomLibrary-SecureRandom'></a>
## SecureRandom `type`

##### Namespace

BlitzkriegSoftware.SecureRandomLibrary

##### Summary

Attempts to implement System.Random but with the `RNGCryptoServiceProvider`

<a name='M-BlitzkriegSoftware-SecureRandomLibrary-SecureRandom-#ctor'></a>
### #ctor() `constructor`

##### Summary

CTOR

##### Parameters

This constructor has no parameters.

<a name='M-BlitzkriegSoftware-SecureRandomLibrary-SecureRandom-#ctor-System-Int32-'></a>
### #ctor(seed) `constructor`

##### Summary

CTOR w. Seed

For compatibility not used

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| seed | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | (ignored) |

<a name='M-BlitzkriegSoftware-SecureRandomLibrary-SecureRandom-Next'></a>
### Next() `method`

##### Summary

Next

##### Returns

Random Positive integer 0 or greater

##### Parameters

This method has no parameters.

<a name='M-BlitzkriegSoftware-SecureRandomLibrary-SecureRandom-Next-System-Int32-'></a>
### Next(max) `method`

##### Summary

Next

##### Returns

0 to max random integer

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| max | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Upper limit (not inclusive) |

<a name='M-BlitzkriegSoftware-SecureRandomLibrary-SecureRandom-Next-System-Int32,System-Int32-'></a>
### Next(min,max) `method`

##### Summary

Next

##### Returns

random integer min to max

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| min | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Lower Limit (inclusive) |
| max | [System.Int32](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Int32 'System.Int32') | Upper limit (not inclusive) |

<a name='M-BlitzkriegSoftware-SecureRandomLibrary-SecureRandom-NextBytes-System-Byte[]-'></a>
### NextBytes(buf) `method`

##### Summary

Next Bytes given initial buffer

##### Parameters

| Name | Type | Description |
| ---- | ---- | ----------- |
| buf | [System.Byte[]](http://msdn.microsoft.com/query/dev14.query?appId=Dev14IDEF1&l=EN-US&k=k:System.Byte[] 'System.Byte[]') | byte array buffer |

<a name='M-BlitzkriegSoftware-SecureRandomLibrary-SecureRandom-NextDouble'></a>
### NextDouble() `method`

##### Summary

Next Double

##### Returns

0 to .999.... Random Double

##### Parameters

This method has no parameters.
