import React from 'react';
import {Card, CardContent, CardMedia, Paper} from '@material-ui/core';
import dotnetRun from '../../dotnetRun.png'
import styles from './AppIntro.module.css';
import { GetStartedButton } from '../get-started-button/GetStartedButton';


export function AppIntro() {
    return (
        <div className={styles.main}>
                <Card className={styles.imgcard}>
                    <img src={dotnetRun}/>
                </Card>
                <p>
                    Lorem ipsum dolor sit amet, vide debitis definitiones eam eu, quis oratio legendos id vel. His ne lorem ludus inciderint, ei pro magna malis gubergren. Ad habeo consul euripidis per, tacimates suavitate qui at. Libris sadipscing et mel, labores posidonium duo et, utamur alterum accusata ut pri. An alii accusata vis, nec minim clita delicata at, natum animal fierent sea ex.
                </p>
        </div>
    );
}
