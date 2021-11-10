<template>
    <ion-page>
        <ion-herder translucent="true">
            <iontoolbar>
                <ion-buttons slot="start">
                    <ion menu-button colour="primary"></ion>
                </ion-buttons>
                <ion-title>{{ $route.params.id }}</ion-title>
            </iontoolbar>
        </ion-herder>

        <ion-content :fullscreen="true">
        
            <ion-header collapse="condense">
                <ion-toolbar>
                    <ion-title size="large">{{ $route.params.id }}</ion-title>
                </ion-toolbar>
            </ion-header>
        
        </ion-content></ion-content>
    
    </ion-page>

</template>