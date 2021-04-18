import React from 'react';
import {AppBar} from '@material-ui/core';
import styles from './Header.module.css';

import { GetStartedButton } from '../get-started-button/GetStartedButton';


export function Header() {
    return (
        <AppBar>
            <div className={styles.headerContent}>
                <h1 className={styles.headerText}>Simple-Microservices</h1>
                <GetStartedButton/>
            </div>
        </AppBar>
    );
}
