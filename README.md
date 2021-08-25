# Faktura Web API

Faktura is a RESTful API that provides querying invoices and creates new invoices.

## Installation

```shell
git clone https://github.com/abdurrahman/faktura.git
cd faktura
dotnet build
```

## API Documentation

> GET api/Invoices/{id}

Response Body:
```json
{
  "data": {
    "type": "invoices",
    "attributes": {
      "dateCreated": "2021-08-24T09:25:15.167",
      "dateUpdated": "2021-08-24T09:30:17.207",
      "referenceId": "5273-101",
      "creditorReference": "101",
      "invoiceExpirationDate": "2031-09-01T00:00:00",
      "invoiceFoundation": false,
      "currency": "TRY",
      "netAmount": 18880,
      "grossAmount": 20950.4,
      "remainder": 20950.4,
      "vatAmount": 2070.4,
      "dueDate": "2021-09-01T00:00:00",
      "date": "2021-08-24T00:00:00",
      "invoiceState": 13,
      "invoiceSource": 0,
      "initialCampaignTypeRequest": 6,
      "invoiceComments": "Some expenses for the Taxi Driver movie",
      "currentProduct": 6
    },
    "id": "659b6ee3-16ca-4ac1-ba53-2ebb1763f082"
  }
}
```

> POST api/Invoices

Request Body:
```json
{
  "date": "2021-08-25T19:06:38.114Z",
  "dueDate": "2021-08-25T19:06:38.114Z",
  "debtor": {
    "firstName": "David",
    "lastName": "Fincher",
    "accountingDebtorId": "5273",
    "email": "david@fincher.com",
    "phone": null,
    "debtorType": 0,
    "address": "Yunus Emre Cd. 56A Ataşehir",
    "zipCode": "34704",
    "city": "Istanbul"
  },
  "currency": "TRY",
  "campaignInitialRequest": 1,
  "lines": [
    {
      "unitNetPrice": 2840,
      "description": "Camera",
      "quantity": 2,
      "vatRate": 18,
      "discountType": 1,
      "discountValue": 280
    },
    {
      "unitNetPrice": 3320.82,
      "description": "Costume",
      "quantity": 4,
      "vatRate": 8,
      "discountType": 1,
      "discountValue": 400
    }
  ],
  "debtCollectionWarningDate": "2021-08-25T19:06:38.114Z",
  "debtRegisterWarningDate": "2021-08-25T19:06:38.114Z"
}
```
Response Body (200 OK):

**Same response with api/Invoices/{id} endpoint**

Response Body (400 Bad Request):
```json
{
  "errors": [
    {
      "status": 400,
      "code": "4",
      "title": "Creditor does not have debt collection enabled"
    }
  ]
}
```

## Built with

* C#, .NET 5.0
* Polly
* Swagger

## To Do

- [ ] Health check
- [ ] FluentValidation
- [ ] Authorization & Authentication
- [ ] Unit Testing
- [ ] Docker

## License
[MIT](LICENSE.md)
