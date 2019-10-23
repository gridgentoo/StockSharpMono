# StockSharp - trading platform 
![Logo](https://avatars0.githubusercontent.com/u/10113234?v=3&s=100)

# Архитектура [StockSharp] & автоматизации торговли на бирже.
https://drive.google.com/drive/folders/1jdVhkw4g7Z-gKweG9bOK1IK-Q1mcBvxY

# Архитектура [Voltdb]  хранение данных в памяти с концепцией распределенной 
https://drive.google.com/drive/folders/1YqYZIwWFvy1lP1NMOxrhZrMX7xZj-628

СУБД VoltDB 3.0, развиваемой под руководством Майкла Стоунбрейкера (Mike Stonebraker), одного из основателей проектов Ingres и PostgreSQL. СУБД VoltDB поддерживает горизонтальное масштабирование и ориентирована на обработку транзакций в реальном времени (OLTP). На недорогом кластере, собранном своими силами из обычных серверов, СУБД способна обрабатывать миллионы транзакций в секунду.

# Apache Hadoop Big Data with VoltDB
![Image alt](https://www.voltdb.com/wp-content/uploads/2017/03/Apache-Hadoop-Big-Data-VoltDB.gif)

Идея VoltDB заключается в том, что все транзакции выполняются с помощью предварительно скомпилированных хранимых процедур, реализованных на Java, и все хранимые процедуры сериализуются, что позволяет VoltDB достичь самого высокого уровня изоляции и устранения блокировок. Использование устройства очень хорошее. В официальных результатах испытаний VoltDB может легко масштабироваться до 39 серверов (300 ядер), 120 разделов, обрабатывающих 1,6 миллиона сложных транзакций в секунду.

# Архитектура [Geode] Реверс инжениринг движка обработки финансовых транзакций в торговых платформах различных компаний на Уолл-стрит.
Geode был создан компанией Gemstone Systems в 2002 году и применяется в качестве высокопроизводительного движка обработки финансовых транзакций в торговых платформах различных компаний на Уолл-стрит.

В качестве примера внедрения Geode это Национальная железная дорога Китая, в которой кластер из 20 узлов (10 основных и 10 запасных) обеспечивает хранение 2 Тб оперативной информации о билетах. 
![Image alt](http://chinalogist.ru/sites/default/files/speed-railwas-of-china4.png)

Архитектура [Geode] & Реверс инжениринг движка обработки финансовых транзакций
https://drive.google.com/drive/folders/1tetUejh8WzscoCbCHPsdILM6desm5GzX

# StockSharp - trading platform #

[StockSharp Home][1] | [Documentation][2] | [Download][3] | [Support][7] | [Algotrading training][4]
----------

## Introduction ##

StockSharp (shortly S#) – are free set of programs for trading at any markets of the world (American, European, Asian, Russian, stocks, futures, options, Bitcoins, forex, etc.). You will be able to trade manually or automated trading (algorithmic trading robots, conventional or HFT).

**Available connections**: FIX/FAST, LMAX, Rithmic, Fusion/Blackwood, Interactive Brokers, OpenECry, Sterling, IQFeed, ITCH, FXCM, QuantHouse, E*Trade, BTCE, BitStamp, BitStamp, Bitfinex, Coinbase, Kraken, Poloniex, GDAX, Bittrex, Bithumb, HitBTC, OKCoin, Coincheck and many other. Any broker or [partner broker (benefits)][6].

## S#.Terminal

S#.Terminal is a free trading charting application (trading terminal). [More info...](https://stocksharp.com/products/terminal/)

### Screenshots

![Terminal](https://stocksharp.com/file/103851?size=500x500)

## S#.Designer

S#.Designer is a free designer of trading strategies. The intuitive interface. Strategies "programming" by mouse or in C#. [More info...](https://stocksharp.com/products/designer/)

### Screenshots

![Designer1](https://stocksharp.com/file/103674?size=400x200)
![Designer2](https://stocksharp.com/file/103666?size=400x200)
![Designer3](https://stocksharp.com/file/103836?size=400x200)
[more on official site...](https://stocksharp.com/products/)

## S#.Data

S#.Data is a free application for downloading and storing market data from various sources (35+). [More info...](https://stocksharp.com/products/hydra/)

## S#.API

S#.API is a free C# library for programmers who use Visual Studio. S#.API lets you create any trading strategy, from long-timeframe positional strategies to high frequency strategies (HFT) with direct access to the exchange (DMA). [More info...](https://stocksharp.com/products/api/)

## Development stage

Current stage of all components - [RELEASE_STAGES.md](../master/_ReleaseNotes/RELEASE_STAGES.md).
Release notes - [RELEASE_NOTES.md](../master/_ReleaseNotes/CHANGE_LOG_API.md).

## License

StockSharp code is licensed under the [Apache License 2.0](../master/LICENSE).

  [1]: https://stocksharp.com
  [2]: https://doc.stocksharp.com
  [3]: https://github.com/StockSharp/StockSharp/releases
  [4]: https://stocksharp.com/edu/
  [5]: https://stocksharp.com/forum/
  [6]: https://stocksharp.com/broker/
  [7]: https://stocksharp.com/support/

