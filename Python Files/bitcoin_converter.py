# Please write your bitcoin_converter program in this file.
#Mark Rogers
#BitCoin Converter (to USD)

def convertBCtoUSD():
    print('As of 10/27/2018 at 8:00 pm, bitcoin is currently trading at $6,405.99 per bitcoin.')
    bitcoin = float(input('Enter the bitcoin amount: '))
    usdValue = bitcoin * 6405.99
    print('That is worth', str(usdValue), 'us dollars.')
          
convertBCtoUSD()