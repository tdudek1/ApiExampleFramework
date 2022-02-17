pipeline { 
        agent {label 'windows'}  


    options {
        skipStagesAfterUnstable()
    }
    stages {
        stage('Build') {
            steps{
                bat 'msbuild .' 
            }
        }            
    }
}