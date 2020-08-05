## SSL

```bash
curl -v https://expired.badssl.com
curl -v -k https://expired.badssl.com

http -v https://expired.badssl.com
http --verify no -v https://expired.badssl.com


curl -v -L https://google.com
http -v https://google.com
```