New-SelfSignedCertificate -DnsName "mydomain.com" -CertStoreLocation "cert:\LocalMachine\My" -KeyExportPolicy Exportable -KeySpec KeyExchange -KeyUsage DigitalSignature, KeyEncipherment -KeyLength 2048