define(['knockout'],
    function (ko) {

        function AddToWallet() {
            this.currencyList = null;
        }

        ko.components.unregister('add-to-wallet');
        ko.components.register('add-to-wallet', {
            viewModel: AddToWallet,
            template: { require: 'text!Content/Wallet/add-to-wallet.html' }
        });
    }
);